using AutoMapper;
using InternPortal.Data;
using InternPortal.Data.Models;
using InternPortal.UI.Dto;
using InternPortal.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace InternPortal.UI.Controllers.API
{
    public class InternServiceController : BaseApiController
    {
        public InternServiceController(IInternUnitOfWork unitOfWork) : base(unitOfWork)
        {

        }

        public IHttpActionResult GetStates()
        {
            var states = new List<string>
            {
                "AK", "AL", "AR", "AZ", "CA", "CO", "CT", "DC", "DE", "FL", "GA", "HI", "IA", "ID", "IL", "IN", "KS", "KY", "LA", "MA", "MD", "ME", "MI", "MN", "MO", "MS", "MT", "NC", "ND", "NE", "NH", "NJ", "NM", "NV", "NY", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VA", "VT", "WA", "WI", "WV", "WY"
            };

            return Ok(states.Select(x => new SelectListItem
            {
                Value = x,
                Text = x
            }).ToList());
        }

        //get all completed apps of user.
        public IHttpActionResult GetUserApplications()
        {
            var UserId = _unitOfWork.AspNetUsers.Where(i => i.UserName == User.Identity.Name).FirstOrDefault()?.Id;

            var applications = Mapper.Map<IEnumerable<ApplicationChildUserDto>>(_unitOfWork.Applications.Where(i=>i.User.Id == UserId &&  i.ApplicationCompleteDate !=null).ToList());

            return Ok(applications);
        }

        //get all completed apps
        public IHttpActionResult GetApplications()
        {
            var applications = Mapper.Map<IEnumerable<ApplicationChildUserDto>>(_unitOfWork.Applications.Where(i=> i.ApplicationCompleteDate != null).ToList());

            return Ok(applications);
        }

        public IHttpActionResult GetApplicationAnswers(int id)
        {
            var questions = _unitOfWork.Questions.GetAll().ToList();

            var answers = _unitOfWork.Answers.Where(a => a.ApplicationId == id).ToList();

            var QuestionAnswers = new List<QuestionAnswerViewModel>();

            foreach (var question in questions.Where(i=>i.QuestionType.QuestionTypeId != (int)Constants.QuestionType.Checkbox))
            {
                    QuestionAnswers.Add(new QuestionAnswerViewModel(question,answers.Where(a=>a.QuestionId == question.QuestionId).FirstOrDefault()));
            }

            foreach (var question in questions.Where(i => i.QuestionType.QuestionTypeId == (int)Constants.QuestionType.Checkbox))
            {
                QuestionAnswers.Add(new QuestionAnswerViewModel(question,answers.Where(i=>i.QuestionId== question.QuestionId)));
            }

            return Ok(QuestionAnswers.OrderBy(i=>i.QuestionId));
        }

        public IHttpActionResult GetApplicationNotes(int id)
        {
            var notes = _unitOfWork.Notes.Where(n => n.ApplicationId == id).ToList();

            return Ok(Mapper.Map<IEnumerable<NoteDto>>(notes));
        }

        public IHttpActionResult GetApplicationStatuses()
        {
            var applicationStatuses = Mapper.Map<IEnumerable<ApplicationStatusDto>>(_unitOfWork.ApplicationStatus.GetAll().ToList());

            return Ok(applicationStatuses);
        }

        public IHttpActionResult UpdateApplication(ApplicationChildUserDto application)
        {
            var applicationToUpdate = _unitOfWork.Applications.Where(i => i.ApplicationId == application.ApplicationId).FirstOrDefault();

            applicationToUpdate.ApplicationStatusId = application.ApplicationStatusId;

            _unitOfWork.Complete();

            return Ok();

        }

        public IHttpActionResult CreateNote(NoteDto note)
        {
            note.UserId = _unitOfWork.AspNetUsers.Where(i => i.UserName == User.Identity.Name).FirstOrDefault()?.Id;

            _unitOfWork.Notes.Add(Mapper.Map<Note>(note));

            _unitOfWork.Complete();

            return Ok(note);
        }

        public IHttpActionResult UpdateNote(NoteDto note)
        {
            var updateNote = _unitOfWork.Notes.Where(n => n.NoteId == note.NoteId).FirstOrDefault();

            if (updateNote != null)
            {

                updateNote.UserId = _unitOfWork.AspNetUsers.Where(i => i.UserName == User.Identity.Name).FirstOrDefault()?.Id;

                updateNote.Note_ = note.Note_;

                _unitOfWork.Complete();
            }

            return Ok(note);
        }

        public IHttpActionResult DeleteNote(NoteDto note)
        {
            var deleteNote = _unitOfWork.Notes.Where(n => n.NoteId == note.NoteId).FirstOrDefault();

            if (deleteNote != null)
            {
                _unitOfWork.Notes.Delete(deleteNote);

                _unitOfWork.Complete();
            }

            return Ok();
        }

        public IHttpActionResult GetUnreadMessages()
        {
            var userId = _unitOfWork.AspNetUsers.Where(i => i.UserName == User.Identity.Name).FirstOrDefault()?.Id;

            var messages = _unitOfWork.Messages.Where(i => i.UserIdTo == userId && i.DateTimeRead == null).ToList();

            return Ok(Mapper.Map<IEnumerable<MessageDto>>(messages));
        }
    }
}