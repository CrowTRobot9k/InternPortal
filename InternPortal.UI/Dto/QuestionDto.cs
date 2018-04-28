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

        // Foreign keys

        /// <summary>
        /// Parent QuestionType pointed by [Question].([QuestionTypeId]) (FK_dbo.Question_dbo.QuestionTypes_QuestionId)
        /// </summary>
        public virtual QuestionTypeDto QuestionType { get; set; } // FK_dbo.Question_dbo.QuestionTypes_QuestionId
    }
}