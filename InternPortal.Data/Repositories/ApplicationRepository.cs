             
using InternPortal.Data;		   
using InternPortal.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace InternPortal.Data.Models
{
    public class ApplicationRepository : Repository<Application>, IApplicationRepository
    {

        public ApplicationRepository(IInternPortalContext context) : base(context)
        {

        }

        //Override any generic method for your own custom implemention, add new repository methods to the IApplicationRepository.cs file
        public Application UpdateApplicationAnswers(Application application,IEnumerable<Question> questions)
        {
            //update or add answer to question
            foreach (var question in questions)
            {
                //questions only 1 possible answer
                if (question.QuestionTypeId != (int)Constants.QuestionType.Checkbox)
                {

                    var updateAnswer = application.Answers.FirstOrDefault(i => i.QuestionId == question.Answers.FirstOrDefault().QuestionId);

                    if (updateAnswer != null)
                    {
                        updateAnswer.AnswerValue = question.Answers.FirstOrDefault().AnswerValue;
                        updateAnswer.OptionValue = question.Answers.FirstOrDefault().OptionValue;
                    }
                    else
                    {
                        application.Answers.Add
                        (
                           question.Answers.FirstOrDefault()
                        );
                    }
                }
                else
                {
                    foreach (var option in question.QuestionOptions)
                    {
                        var updateMultipleAnswer = application.Answers.FirstOrDefault(i => i.QuestionId == option.QuestionId && i.OptionId == option.OptionId);

                        if (updateMultipleAnswer != null)
                        {
                            updateMultipleAnswer.OptionValue = option.Answers.FirstOrDefault().OptionValue;
                            updateMultipleAnswer.AnswerValue = option.Answers.FirstOrDefault().AnswerValue;
                        }
                        else
                        {
                            application.Answers.Add
                            (
                               option.Answers.FirstOrDefault()
                            );
                        }
                    }
                }
            }
            return application;
        }

        public Application UpdateApplicationUploads(Application application, IEnumerable<UserUpload> uploads)
        {
            application.UserUploads.Clear();

            uploads.ToList().ForEach(u=> application.UserUploads.Add(u));

            return application;
        }

    }
}
