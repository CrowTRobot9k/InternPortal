using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternPortal.UI.Dto
{
    public class PositionDto
    {
        public int PositionId { get; set; } // PositionId (Primary key)
        public string PositionName { get; set; } // PositionName (length: 100)
        public string PositionDescription { get; set; } // PositionDescription
    }
}