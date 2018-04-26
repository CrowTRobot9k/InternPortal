using InternPortal.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace InternPortal.UI.Controllers.API
{
    public abstract partial class BaseApiController : ApiController
    {    
        protected IInternUnitOfWork _unitOfWork;
        
        protected BaseApiController(IInternUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
    }
}