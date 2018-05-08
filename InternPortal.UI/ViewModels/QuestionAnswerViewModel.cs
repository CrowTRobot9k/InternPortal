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
        public QuestionAnswerViewModel(int questionId, string question, Answer answer)
        {
            QuestionId = questionId;
            Question = question;
            if (answer.Question.QuestionTypeId != (int)Constants.QuestionType.Checkbox)
            {
                Answer = answer.AnswerValue;
            }
            else
            {
                Answer = string.Join(",",answer.QuestionOption.Answers.Where(i => i.OptionValue ?? false).Select(i => i.QuestionOption.OptionValue).ToList());
            }
        }

       public int QuestionId { get; set; }
       public string Question { get; set; }
       public string Answer { get; set; }
    }
}