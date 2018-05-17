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
    [Authorize]
    public class MessageController : BaseController
    {
        public MessageController(IInternUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public ActionResult Conversations()
        {
            var userLoggedIn = _unitOfWork.AspNetUsers.Where(i => i.UserName == User.Identity.Name).FirstOrDefault();

            var converstations = Mapper.Map<IEnumerable<AspNetUserDto>>(_unitOfWork.Messages.GetConversations(userLoggedIn));

            return View(converstations.GroupBy(i=>i.Id).Select(i=>i.FirstOrDefault()).ToList());
        }

        //if accessing from grid
        public ActionResult AdminMessage(int userId)
        {
            //current user logged in is messenger.
            var aspUserFrom  = _unitOfWork.AspNetUsers.Where(i => i.UserName == User.Identity.Name).FirstOrDefault();
            var UserTo = _unitOfWork.Users.Where(i => i.UserId == userId).FirstOrDefault();
            var aspUserTo = UserTo.AspNetUser;

            var viewModel = GetConversation(aspUserFrom, aspUserTo);

            return View("Messages",viewModel);
        }

        //if accessing from conversation page.
        public ActionResult UserMessage(string userId)
        {
            //current user logged in is messenger.
            var aspUserFrom = _unitOfWork.AspNetUsers.Where(i => i.UserName == User.Identity.Name).FirstOrDefault();
            var aspUserTo = _unitOfWork.AspNetUsers.Where(i => i.Id == userId).FirstOrDefault();

            var viewModel = GetConversation(aspUserFrom, aspUserTo);

            return View("Messages", viewModel);
        }

        private MessageViewModel GetConversation(AspNetUser aspUserFrom, AspNetUser aspUserTo)
        {
            //get conversations containing both users.
            var messages = _unitOfWork.Messages.Where(m => (m.UserIdFrom == aspUserFrom.Id && m.UserIdTo == aspUserTo.Id) ||
            m.UserIdTo == aspUserFrom.Id && m.UserIdFrom == aspUserTo.Id);

            //if messages are addressed to user mark as viewed.
            foreach (var message in messages)
            {
                if (message.UserIdTo == aspUserFrom.Id)
                {
                    message.DateTimeRead = DateTime.Now;
                }
            }

            _unitOfWork.Complete();

            var viewModel = new MessageViewModel()
            {
                User = Mapper.Map<AspNetUserDto>(aspUserFrom),
                UserTo = Mapper.Map<AspNetUserDto>(aspUserTo),
                Messages = Mapper.Map<IEnumerable<MessageDto>>(messages).ToList(),
                //initialize new message to send.
                Message = new MessageDto
                {
                    UserIdFrom = aspUserFrom.Id,
                    UserIdTo = aspUserTo.Id
                }
            };
            return viewModel;
        }

        [HttpPost]
        public ActionResult SendMessage(MessageViewModel viewModel)
        {
            if (!ModelState.IsValid && !string.IsNullOrEmpty(viewModel.Message.MessageBody))
            {
                //TODO: add full model binding and error
                return RedirectToAction("UserMessage", "Message", new { userId = viewModel.Message.UserIdTo });
            }

            viewModel.Message.DateTimeSent = DateTime.Now;

            _unitOfWork.Messages.Add(Mapper.Map<Message>(viewModel.Message));

            _unitOfWork.Complete();

            return RedirectToAction("UserMessage", "Message", new { userId = viewModel.UserTo.Id });
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