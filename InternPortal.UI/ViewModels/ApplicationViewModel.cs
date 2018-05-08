using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InternPortal.Data.Models;
using InternPortal.UI.Dto;

namespace InternPortal.UI.ViewModels
{
    public class ApplicationViewModel
    {
        public UserDto User { get; set; }

        public ApplicationDto Application { get; set; }

        public List<QuestionDto> Questions { get; set; }
    }
}