using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternPortal.UI.Dto
{
    public class QuestionDto
    {
        public int QuestionId { get; set; } // QuestionId (Primary key)
        public int QuestionTypeId { get; set; } // QuestionTypeId
        public string Question_ { get; set; } // Question

        public List<AnswerDto> Answers { get; set; } // Answers.FK_dbo.Answers_dbo.Question_QuestionId

        public List<QuestionOptionDto> QuestionOptions { get; set; } // QuestionOptions.FK_dbo.QuestionOptions_dbo.Question_QuestionId
  
        public QuestionTypeDto QuestionType { get; set; } // FK_dbo.Question_dbo.QuestionTypes_QuestionId
    }
}