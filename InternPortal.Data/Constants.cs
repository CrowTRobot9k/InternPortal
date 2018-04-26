using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternPortal.Data
{
    public class Constants
    {
        //pending, reviewed, phone interviewed, offer extended, hired, rejected 
        public enum ApplicationStatus
        {
            Pending = 1,
            Reviewed = 2,
            PhoneInterviewed = 3,
            InPersonInterview = 4,
            OfferExtended = 5,
            Hired = 6,
            Rejected = 7
        }

        public enum QuestionType
        {
            TextBox = 1,
            TextArea = 2,
            RadioButton = 3,
            Checkbox = 4,
            DropDown = 5,
            Date = 6,
            Numeric = 7
        }
    }
}
