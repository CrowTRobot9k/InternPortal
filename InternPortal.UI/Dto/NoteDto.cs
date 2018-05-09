using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternPortal.UI.Dto
{
    public class NoteDto
    {
        public int NoteId { get; set; } // NoteId (Primary key)
        public int ApplicationId { get; set; } // ApplicationId
        public string UserId { get; set; } // UserId (length: 128)
        public string Note_ { get; set; } // Note

        public AspNetUserDto AspNetUser { get; set; } // FK_Note_AspUser
    }
}