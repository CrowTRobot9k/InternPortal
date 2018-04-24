using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InternPortal.UI.Models;

namespace InternPortal.UI.Controllers
{
    [ChildActionOnly]
    public class MenuController : Controller
    {
        // GET: Menu
        public ActionResult Index()
        {
            return PartialView("_Menu", new Menu());
        }
    }
}