using InternPortal.Data.Models;
using InternPortal.UI.Dto;
using InternPortal.UI.ViewModels;
using Kendo.Mvc.Extensions;
using System.IO;
using System.Linq;
using System.Web.Mvc;

namespace InternPortal.UI.Controllers
{
    [System.Web.Mvc.Authorize]
    public class HomeController : BaseController
    {
        public HomeController(IInternUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
        }

        public ActionResult Index()
        {
            var aspUser = _unitOfWork.AspNetUsers.Where(i => i.UserName == User.Identity.Name).FirstOrDefault();
            var user = _unitOfWork.Users.Where(i => i.Id == aspUser.Id).FirstOrDefault();

            var viewModel = new HomePageViewModel()
            {
                DomainUser = aspUser,
                User = user
            };

            return View(viewModel);
        }

        [System.Web.Http.HttpGet]
        public void DownloadFile(int id)
        {
            var uploadLocation = Server.MapPath(System.Configuration.ConfigurationManager.AppSettings["UploadLocation"]);

            var upload = _unitOfWork.UserUploads.Where(u => u.UploadId == id).FirstOrDefault();

            var ext = Path.GetExtension(upload.UploadLocation);

            var response = System.Web.HttpContext.Current.Response;
            response.ClearContent();
            response.Clear();
            response.ContentType = "text/plain";
            response.AddHeader("Content-Disposition",
                               "attachment; filename=" + upload.UploadTitle + ext + ";");
            response.TransmitFile(Server.MapPath(uploadLocation + upload.UploadLocation));
            response.Flush();
            response.End();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult ApplicationUpdate(ApplicationChildUserDto application)
        {
            if (ModelState.IsValid)
            {
                var applicationToUpdate = _unitOfWork.Applications.Where(i => i.ApplicationId == application.ApplicationId).FirstOrDefault();

                applicationToUpdate.ApplicationStatusId = application.ApplicationStatusId;

                _unitOfWork.Complete();

                var routeValues = this.GridRouteValues();

                return RedirectToAction("Index", routeValues);
            }

            return RedirectToAction("Index");
        }
    }
}