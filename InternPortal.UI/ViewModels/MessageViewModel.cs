using InternPortal.UI.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternPortal.UI.ViewModels
{
    public class MessageViewModel
    {
        public List<MessageDto> Messages { get; set; }
        public MessageDto Message { get; set; }
    }
}