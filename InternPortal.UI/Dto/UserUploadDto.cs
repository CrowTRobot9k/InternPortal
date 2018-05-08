using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternPortal.UI.Dto
{
    public class UserUploadDto
    {
        public int UploadId { get; set; } // UploadId (Primary key)
        public int? UserId { get; set; } // UserId
        public int? ApplicationId { get; set; } // ApplicationId
        public string UploadLocation { get; set; } // UploadLocation
        public string UploadTitle { get; set; } // UploadTitle
        public string UploadDescription { get; set; } // UploadDescription
    }
}