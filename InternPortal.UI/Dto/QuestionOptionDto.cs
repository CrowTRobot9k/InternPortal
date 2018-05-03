using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternPortal.UI.Dto
{
    public class QuestionOptionDto
    {
        public int OptionId { get; set; } // OptionId (Primary key)
        public int QuestionId { get; set; } // QuestionId
        public string OptionValue { get; set; } // OptionValue

        public List<AnswerDto> Answers { get; set; }
    }
}