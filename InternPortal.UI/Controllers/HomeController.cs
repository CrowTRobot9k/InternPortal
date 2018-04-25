using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using InternPortal.Data.Models;

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
            return View();
        }
    }
}