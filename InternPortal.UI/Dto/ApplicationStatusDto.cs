using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternPortal.UI.Dto
{
    public class ApplicationStatusDto
    {
        public int ApplicationStatusId { get; set; } // ApplicationStatusId (Primary key)
        public string Status { get; set; } // Status (length: 50)
    }
}