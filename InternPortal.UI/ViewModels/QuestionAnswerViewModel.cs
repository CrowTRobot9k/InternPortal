using InternPortal.Data;
using InternPortal.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternPortal.UI.ViewModels
{
    public class QuestionAnswerViewModel
    {
        public QuestionAnswerViewModel(Question question, Answer answer)
        {
            QuestionId = question.QuestionId;
            Question = question.Question_;
            Answer = answer.AnswerValue;
            
        }

        public QuestionAnswerViewModel(Question question, IEnumerable<Answer> answers)
        {
            QuestionId = question.QuestionId;
            Question = question.Question_;
            Answer = string.Join(",", answers.Where(i => i.QuestionId==question.QuestionId && i.OptionValue== true).Select(i=>i.QuestionOption.OptionValue).ToList());
        }

       public int QuestionId { get; set; }
       public string Question { get; set; }
       public string Answer { get; set; }
    }
}