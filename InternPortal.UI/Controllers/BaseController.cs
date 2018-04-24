using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using InternPortal.Data.Models;


namespace InternPortal.UI.Controllers
{
    public abstract partial class BaseController : Controller
    {
        protected IInternUnitOfWork _unitOfWork;
        
        protected BaseController(IInternUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

    }
}