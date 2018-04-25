using InternPortal.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InternPortal.UI.Controllers
{
    public class UserController : BaseController
    {
        public UserController(IInternUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public ActionResult ViewAll()
        {
            return View();
        }

        public ActionResult CreateUser()
        {
            return View();
        }

        public ActionResult ViewUser()
        {
            return View();
        }

        public ActionResult UpdateUser()
        {
            return View();
        }

        public ActionResult DeleteUser()
        {
            return View();
        }

    }
}