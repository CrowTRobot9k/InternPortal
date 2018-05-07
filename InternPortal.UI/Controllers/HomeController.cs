using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}