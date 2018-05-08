using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using InternPortal.Data.Models;
using InternPortal.UI.ViewModels;

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

            string ext = Path.GetExtension(upload.UploadLocation);

            System.Web.HttpResponse response = System.Web.HttpContext.Current.Response;
            response.ClearContent();
            response.Clear();
            response.ContentType = "text/plain";
            response.AddHeader("Content-Disposition",
                               "attachment; filename=" + upload.UploadTitle + ext+";");
            response.TransmitFile(Server.MapPath(System.Configuration.ConfigurationManager.AppSettings["UploadLocation"]+upload.UploadLocation));
            response.Flush();
            response.End();
        }
    }
}