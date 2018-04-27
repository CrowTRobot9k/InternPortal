using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InternPortal.Data.Models;

namespace InternPortal.UI.ViewModels
{
    public class ApplicationViewModel
    {
        public Application Application { get; set; }

        public List<QuestionAnswerViewModel> QuestionAnswers { get; set; }
    }
}