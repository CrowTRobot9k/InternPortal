using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternPortal.UI.Dto
{
    public class MessageDto
    {
        public int MessageId { get; set; } // MessageId (Primary key)
        public string UserIdFrom { get; set; } // UserIdFrom (length: 128)
        public string UserIdTo { get; set; } // UserIdTo (length: 128)
        public string MessageSubject { get; set; } // MessageSubject
        public string MessageBody { get; set; } // MessageBody
        public System.DateTime? DateTimeSent { get; set; } // DateTimeSent

    }
}