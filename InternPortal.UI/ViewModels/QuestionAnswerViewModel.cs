using InternPortal.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternPortal.UI.ViewModels
{
    public class QuestionAnswerViewModel
    {
        public QuestionAnswerViewModel(Question question, List<Answer> answers)
        {
            Question = question;
            foreach (var qo in Question.QuestionOptions.ToList())
            {
                //if no corresponding answer add blank answer for that option for checkboxes, radioboxes, an multiselect.
                if (!answers.Select(i => i.OptionId).Contains(qo.OptionId))
                {
                    answers.Add(new Answer() { OptionId = qo.OptionId, OptionValue = false });
                }
            }
            Answers = answers; 
        }

        public Question Question { get; set; }

        public List<Answer> Answers { get; set; }
    }
}