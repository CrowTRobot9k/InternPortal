using InternPortal.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace InternPortal.UI.Controllers.API
{
    public class InternServiceController : BaseApiController
    {
        public InternServiceController(IInternUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public IHttpActionResult GetStates()
        {
            List<string> states = new List<string>()
            {
                "AK", "AL", "AR", "AZ", "CA", "CO", "CT", "DC", "DE", "FL", "GA", "HI", "IA", "ID", "IL", "IN", "KS", "KY", "LA", "MA", "MD", "ME", "MI", "MN", "MO", "MS", "MT", "NC", "ND", "NE", "NH", "NJ", "NM", "NV", "NY", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VA", "VT", "WA", "WI", "WV", "WY"
            };

            return Ok(states.Select(x => new SelectListItem
            {
                Value = x,
                Text = x
            }).ToList());
        }

        //public class State
        //{
        //    public State(string name)
        //    {
        //        this.stateName = name;
        //    }
        //    string stateName { get; set; }
        //}
    }
}