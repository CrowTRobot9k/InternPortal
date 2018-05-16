using InternPortal.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InternPortal.UI.Controllers
{
    [Authorize]
    public class PositionController : BaseController
    {
        public PositionController(IInternUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public ActionResult Positions()
        {
            return View();
        }
    }
}