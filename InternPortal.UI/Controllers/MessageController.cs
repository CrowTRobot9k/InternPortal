using InternPortal.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InternPortal.UI.Controllers
{
    public class MessageController : BaseController
    {
        public MessageController(IInternUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public ActionResult ViewAll()
        {
            return View();
        }

        public ActionResult CreateMessage()
        {
            return View();
        }

        public ActionResult ViewMessage()
        {
            return View();
        }

        public ActionResult UpdateMessage()
        {
            return View();
        }

        public ActionResult DeleteMessage()
        {
            return View();
        }

    }
}