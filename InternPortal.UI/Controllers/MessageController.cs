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

        public ActionResult Messages(string userId)
        {
            //current user logged in is messenger.
            var aspUser = _unitOfWork.AspNetUsers.Where(i => i.UserName == User.Identity.Name).FirstOrDefault();


            //get conversations containing both users.
            var messages = _unitOfWork.Messages.Where(m => (m.UserIdFrom == aspUser.Id && m.UserIdTo == userId) ||
            m.UserIdTo == aspUser.Id && m.UserIdFrom == userId);

            var viewModel = new MessageViewModel()
            {
                Messages = Mapper.Map<IEnumerable<MessageDto>>(messages).ToList(),
                Message = new MessageDto()
            };

            return View(viewModel);
        }

        public ActionResult Message()
        {
            return View();
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