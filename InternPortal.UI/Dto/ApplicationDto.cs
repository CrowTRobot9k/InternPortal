using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternPortal.UI.Dto
{
    public class ApplicationDto
    {
        public int ApplicationId { get; set; } // ApplicationId (Primary key)
        public int UserId { get; set; } // UserId
        public System.DateTime? ApplicationStartDate { get; set; } // ApplicationStartDate
        public System.DateTime? ApplicationCompleteDate { get; set; } // ApplicationCompleteDate
        public int? ApplicationStatus { get; set; } // ApplicationStatus

        // Foreign keys

        /// <summary>
        /// Parent User pointed by [Application].([UserId]) (FK_dbo.Application_dbo.User_UserId)
        /// </summary>
        public virtual UserDto User { get; set; } // FK_dbo.Application_dbo.User_UserId
    }
}