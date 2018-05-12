using AutoMapper;
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
    public class MessageController : BaseController
    {
        public MessageController(IInternUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public ActionResult ViewAll()
        {
            return View();
        }

        public ActionResult Messages(int userId)
        {
            //current user logged in is messenger.
            var aspUserFrom  = _unitOfWork.AspNetUsers.Where(i => i.UserName == User.Identity.Name).FirstOrDefault();
            var aspUserTo = _unitOfWork.Users.Where(i => i.UserId == userId).FirstOrDefault().AspNetUser;

            //get conversations containing both users.
            var messages = _unitOfWork.Messages.Where(m => (m.UserIdFrom == aspUserFrom.Id && m.UserIdTo == aspUserTo.Id) ||
            m.UserIdTo == aspUserFrom.Id && m.UserIdFrom == aspUserTo.Id);

           
            var viewModel = new MessageViewModel()
            {
                User = Mapper.Map<AspNetUserDto>(aspUserFrom),
                Messages = Mapper.Map<IEnumerable<MessageDto>>(messages).ToList(),
                //initialize new message to send.
                Message = new MessageDto
                {
                    UserIdFrom = aspUserFrom.Id,
                    UserIdTo = aspUserTo.Id
                }
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult SendMessage(MessageDto message)
        {
            if (!ModelState.IsValid && !string.IsNullOrEmpty(message.MessageBody))
            {
                //TODO: add full model binding and error
                return RedirectToAction("Messages");
            }

            message.DateTimeSent = DateTime.Now;

            _unitOfWork.Messages.Add(Mapper.Map<Message>(message));

            _unitOfWork.Complete();

            return RedirectToAction("Messages");
        }

        public ActionResult UpdateMessage()
        {
            return View();
        }

        public ActionResult DeleteMessage()
        {
            return View();
        }

    }
}