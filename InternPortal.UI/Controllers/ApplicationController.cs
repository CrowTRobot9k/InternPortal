using InternPortal.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InternPortal.UI.Controllers
{
    public class ApplicationController : BaseController
    {
        public ApplicationController(IInternUnitOfWork unitOfWork):base(unitOfWork)
        {
        }

        //View all applications to manage
        public ActionResult ViewAll()
        {
            return View();
        }

        public ActionResult CreateApplication()
        {

            return View();
        }

        public ActionResult ViewApplication()
        {
            return View();
        }

        public ActionResult UpdateApplication()
        {
            return View();
        }

        public ActionResult DeleteApplication()
        {
            return View();
        }



    }
}