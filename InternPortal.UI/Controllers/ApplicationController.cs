using AutoMapper;
using InternPortal.Data;
using InternPortal.Data.Models;
using InternPortal.UI.Dto;
using InternPortal.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web.Mvc;

namespace InternPortal.UI.Controllers
{
    [Authorize]
    public class ApplicationController : BaseController
    {
        public ApplicationController(IInternUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        //View all applications to manage
        public ActionResult ViewAll()
        {
            return View();
        }

        public ActionResult Application()
        {
            var aspUser = _unitOfWork.AspNetUsers.Where(i => i.UserName == User.Identity.Name).FirstOrDefault();
            var user = _unitOfWork.Users.Where(i => i.Id == aspUser.Id).FirstOrDefault() ?? new User();

            var viewModel = new ApplicationViewModel()
            {
                User = Mapper.Map<UserDto>(user),
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
                viewModel.Application.ApplicationStatusId = (int)Constants.ApplicationStatus.Pending;
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

            //get upload
            if (!viewModel.Application.UserUploads.Any())
            {
                viewModel.Application.UserUploads.Add(new UserUploadDto());
            }

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult SaveApplication(ApplicationViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View("Application", viewModel);
            }

            //save user
            //add or update user
            //Todo?:Maybe change to "Profile" with 1 to 1 relationship with Application.
            var userToSave = _unitOfWork.Users.Where(i => i.UserId == viewModel.User.UserId).FirstOrDefault();

            if (userToSave != null)
            {
                _unitOfWork.Context().Entry(userToSave).CurrentValues.SetValues(viewModel.User);
            }
            else
            {
                var aspUser = _unitOfWork.AspNetUsers.Where(i => i.UserName == User.Identity.Name).FirstOrDefault();

                viewModel.User.Id = aspUser.Id;

                _unitOfWork.Users.Add(Mapper.Map<User>(viewModel.User));
            }
            //_unitOfWork.Complete();
            //save user

            //delete old upload and save new one.
            //Todo?: allow for multiple file uploads and delete upload function. For now Appplication only has one upload.
            foreach (string file in Request.Files)
            {
                var postedFile = Request.Files[file];
                if (!string.IsNullOrEmpty(postedFile.FileName))
                {
                    try
                    {
                        var uploadLocation = Server.MapPath(System.Configuration.ConfigurationManager.AppSettings["UploadLocation"]);

                        //Todo: maybe find better way to store files. Current format is Uploads\ApplicationId\
                        var applicationDirectory = uploadLocation + viewModel.Application.ApplicationId + "\\";

                        if (!Directory.Exists(applicationDirectory))
                        {
                            Directory.CreateDirectory(applicationDirectory);
                        }

                        //delete old files
                        var di = new DirectoryInfo(applicationDirectory);

                        foreach (var oldFile in di.GetFiles())
                        {
                            oldFile.Delete();
                        }

                        //Save new file
                        var fullFilePath = applicationDirectory + postedFile.FileName;

                        if (!System.IO.File.Exists(fullFilePath))
                        {
                            try
                            {
                                postedFile.SaveAs(fullFilePath);
                            }
                            catch (Exception ex)
                            {
                                //Todo: add logger.
                            }
                        }

                        var userUpload = viewModel.Application.UserUploads.FirstOrDefault();

                        userUpload.UploadLocation = viewModel.Application.ApplicationId + "\\" + postedFile.FileName;
                    }
                    catch (Exception ex)
                    {
                        //Todo: add logger.
                    }
                }
                else
                {
                    viewModel.Application.UserUploads.Clear();
                }
            }

            var applicationToSave = _unitOfWork.Applications.Where(i => i.ApplicationId == viewModel.Application.ApplicationId).FirstOrDefault();

            if (applicationToSave != null)
            {
                viewModel.Application.Answers = Mapper.Map<IEnumerable<AnswerDto>>(_unitOfWork.Answers.Where(a => a.ApplicationId == viewModel.Application.ApplicationId).ToList() ?? new List<Answer>()).ToList();

                //save answers
                applicationToSave = _unitOfWork.Applications.UpdateApplicationAnswers(applicationToSave, Mapper.Map<IEnumerable<Question>>(viewModel.Questions));

                //save uploads
                applicationToSave = _unitOfWork.Applications.UpdateApplicationUploads(applicationToSave, Mapper.Map<IEnumerable<UserUpload>>(viewModel.Application.UserUploads));
            }
            else
            {
                viewModel.Application = Mapper.Map<ApplicationDto>(_unitOfWork.Applications.UpdateApplicationAnswers(Mapper.Map<Application>(viewModel.Application), Mapper.Map<IEnumerable<Question>>(viewModel.Questions)));

                viewModel.Application = Mapper.Map<ApplicationDto>(_unitOfWork.Applications.UpdateApplicationUploads(Mapper.Map<Application>(viewModel.Application), Mapper.Map<IEnumerable<UserUpload>>(viewModel.Application.UserUploads)));
            }

            //add or update application
            if (applicationToSave != null)
            {
                //add or update each answer
                foreach (var answer in applicationToSave.Answers)
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

                //TODO: Allow update of uploads.
                var uploadsToUpdate = _unitOfWork.UserUploads.Where(a => a.ApplicationId == applicationToSave.ApplicationId);

                uploadsToUpdate.ToList().ForEach(i => _unitOfWork.UserUploads.Delete(i));

                applicationToSave.UserUploads.ToList().ForEach(u =>
                      applicationToSave.UserUploads.Add(u));

                _unitOfWork.Context().Entry(applicationToSave).CurrentValues.SetValues(Mapper.Map<Application>(viewModel.Application));
            }
            else
            {
                _unitOfWork.Applications.Add(Mapper.Map<Application>(viewModel.Application));
            }

            _unitOfWork.Complete();

            //TODO: return the viewModel instead.
            return RedirectToAction("Application");
        }

        public ActionResult SubmitApplication(int id)
        {
            var applicationToSubmit = _unitOfWork.Applications.Where(a => a.ApplicationId == id).FirstOrDefault();

            if (applicationToSubmit == null)
            {
                //Todo: add error messages
                return RedirectToAction("Application");
            }
            else
            {
                applicationToSubmit.ApplicationCompleteDate = DateTime.Now;

                _unitOfWork.Complete();
            }

            return View();
        }
    }
}