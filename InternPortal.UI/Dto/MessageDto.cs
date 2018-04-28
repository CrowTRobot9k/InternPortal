using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternPortal.UI.Dto
{
    public class MessageDto
    {
        public int MessageId { get; set; } // MessageId (Primary key)
        public int UserIdFrom { get; set; } // UserIdFrom
        public int UserIdTo { get; set; } // UserIdTo
        public string MessageSubject { get; set; } // MessageSubject
        public string MessageBody { get; set; } // MessageBody
        public System.DateTime? DateTimeSent { get; set; } // DateTimeSent
    }
}