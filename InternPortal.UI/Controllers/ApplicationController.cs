using AutoMapper;
using InternPortal.Data;
using InternPortal.Data.Models;
using InternPortal.UI.Dto;
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
                Application = Mapper.Map<ApplicationDto>(_unitOfWork.Applications.GetAll()
                                .Where(i => i.UserId == user.UserId && i.ApplicationCompleteDate == null).FirstOrDefault()
                                ?? new Application())
            };

            //new application: assign user, start date, initial pending status (should interviews be pending if they are not completed?).
            if (viewModel.Application.ApplicationId == 0)
            {
                viewModel.Application.UserId = user.UserId;
                viewModel.Application.ApplicationStartDate = DateTime.Now;
                viewModel.Application.ApplicationStatus = (int)Constants.ApplicationStatus.Pending;
                
           }

            //get all questions
            viewModel.Questions = Mapper.Map<IEnumerable<QuestionDto>>(_unitOfWork.Questions.GetAll().ToList()).ToList();

            //get answer to each question or initialize new answer for question.
            foreach (var question in viewModel.Questions)
            {
                //questions only 1 possible answer
                if (question.QuestionType.QuestionTypeId != (int)Constants.QuestionType.Checkbox)
                {
                    question.Answers = viewModel.Application.Answers.Where(a =>
                                   a.QuestionId == question.QuestionId
                                && a.ApplicationId == viewModel.Application.ApplicationId
                                ).ToList();

                    if (!question.Answers.Any(a => a.QuestionId == question.QuestionId && a.ApplicationId == viewModel.Application.ApplicationId))
                    {
                        question.Answers.Add(new AnswerDto() { QuestionId = question.QuestionId });
                    }
                }
                //questions with multiple possible answers
                else
                {
                    foreach (var option in question.QuestionOptions)
                    {
                        option.Answers = viewModel.Application.Answers.Where(a =>
                        a.QuestionId == question.QuestionId
                        && a.ApplicationId == viewModel.Application.ApplicationId
                        && a.OptionId == option.OptionId).ToList();

                        if (!option.Answers.Any(a => a.QuestionId == question.QuestionId && a.ApplicationId == viewModel.Application.ApplicationId && a.OptionId == option.OptionId))
                        {
                            option.Answers.Add(new AnswerDto() { QuestionId = question.QuestionId, OptionId = option.OptionId });
                        }
                    }
                }
            }
           
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult SaveApplication(ApplicationViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("CreateApplication", viewModel);
            }

            var applicationToSave = _unitOfWork.Applications.Where(i => i.ApplicationId == viewModel.Application.ApplicationId).FirstOrDefault();

            if (applicationToSave != null)
            {
                viewModel.Application.Answers = Mapper.Map<IEnumerable<AnswerDto>>(_unitOfWork.Answers.Where(a => a.ApplicationId == viewModel.Application.ApplicationId).ToList() ?? new List<Answer>()).ToList();

                applicationToSave = _unitOfWork.Applications.UpdateApplicationAnswers(applicationToSave, Mapper.Map<IEnumerable<Question>>(viewModel.Questions));
            }
            else
            {
                viewModel.Application = Mapper.Map<ApplicationDto>(_unitOfWork.Applications.UpdateApplicationAnswers(Mapper.Map<Application>(viewModel.Application), Mapper.Map<IEnumerable<Question>>(viewModel.Questions)));
            }

            //add or update application
            if (applicationToSave != null)
            {
                //add or update each answer
                foreach (var answer in viewModel.Application.Answers)
                {
                    var answerToUpdate = _unitOfWork.Answers.Where(a => a.AnswerId == answer.AnswerId).FirstOrDefault();

                    if (answerToUpdate != null)
                    {
                        _unitOfWork.Context().Entry(answerToUpdate).CurrentValues.SetValues(Mapper.Map<Answer>(answer));
                    }
                    else
                    {
                        _unitOfWork.Answers.Add(Mapper.Map<Answer>(answer));
                    }
                        
                }

                _unitOfWork.Context().Entry(applicationToSave).CurrentValues.SetValues(Mapper.Map<Application>(viewModel.Application));
            }
            else
            {
                _unitOfWork.Applications.Add(Mapper.Map<Application>(viewModel.Application));
            }

            _unitOfWork.Complete();

            return RedirectToAction("CreateApplication");
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