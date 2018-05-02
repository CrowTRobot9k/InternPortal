using InternPortal.Data;
using InternPortal.Data.Models;
using InternPortal.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InternPortal.UI.Controllers
{
    [Authorize]
    public class ApplicationController : BaseController
    {
        public ApplicationController(IInternUnitOfWork unitOfWork):base(unitOfWork)
        {
        }

        //View all applications to manage
        public ActionResult ViewAll()
        {
            return View();
        }

        public ActionResult CreateApplication()
        {
            var aspUser = _unitOfWork.AspNetUsers.Where(i => i.UserName == User.Identity.Name).FirstOrDefault();
            var user = _unitOfWork.Users.Where(i => i.Id == aspUser.Id).FirstOrDefault();

            if (user == null)
            {
                return RedirectToAction("CreateUser", "User");
            }

            var viewModel = new ApplicationViewModel()
            {
                //get in progress application or new
                Application = _unitOfWork.Applications.GetAll()
                                .Where(i => i.UserId == user.UserId && i.ApplicationCompleteDate != null).FirstOrDefault()
                                ?? new Application()
            };

            //new application: assign user, start date, initial pending status (should interviews be pending if they are not completed?).
            if (viewModel.Application.ApplicationId == 0)
            {
                viewModel.Application.UserId = user.UserId;
                viewModel.Application.ApplicationStartDate = DateTime.Now;
                viewModel.Application.ApplicationStatus = (int)Constants.ApplicationStatus.Pending;
                
           }

            //get all questions
            var questions = _unitOfWork.Questions.GetAll().ToList();

            //get answer to each question or initialize new answer for question.
            //foreach (var question in questions)
            //{
            //    viewModel.QuestionAnswers.Add(
            //        new QuestionAnswerViewModel(question,
            //           question.QuestionOptions?? _unitOfWork.Answers.
            //        Where(a => a.QuestionId == question.QuestionId
            //            && a.ApplicationId == viewModel.Application.ApplicationId 
            //            && question.QuestionOptions.Select(i=> i.OptionId)==a.OptionId).ToList()

            //        )
            //    };
            //}


            //viewModel.QuestionAnswers = 
            //    questions.Select(i => 
            //new QuestionAnswerViewModel(i,
            //    _unitOfWork.Answers.
            //        Where(a=>a.QuestionId==i.QuestionId 
            //            && a.ApplicationId==(viewModel.Application.ApplicationId))
            //                .ToList()?? new List<Answer>())
            //).ToList();

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult SaveApplication(ApplicationViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("CreateUser", viewModel);
            }


            //viewModel.QuestionAnswers.Select(i => i.Answers.Select(answer => viewModel.Application.Answers.Add(new Answer { A})));
            foreach (var qa in viewModel.QuestionAnswers)
            {
                //update or add answer to question
                foreach (var answer in qa.Answers)
                {
                    var updateAnswer = viewModel.Application.Answers.FirstOrDefault(i => i.AnswerId == answer.AnswerId);

                    if (updateAnswer!=null)
                    {
                        updateAnswer=answer;
                    }
                    else
                    {
                        answer.QuestionId = qa.Question.QuestionId;

                        viewModel.Application.Answers.Add
                        (
                           answer
                        );
                    }
                }
            }

            var applicationToSave = _unitOfWork.Applications.Where(i => i.ApplicationId == viewModel.Application.ApplicationId).FirstOrDefault();

            //add or update application
            if (applicationToSave != null)
            {
                _unitOfWork.Context().Entry(applicationToSave).CurrentValues.SetValues(viewModel.Application);
            }
            else
            {
                _unitOfWork.Applications.Add(viewModel.Application);
            }

            _unitOfWork.Complete();

            return View("CreateApplication",viewModel);
        }

        public ActionResult UpdateApplication()
        {
            return View();
        }

        public ActionResult DeleteApplication()
        {
            return View();
        }



    }
}