using InternPortal.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace InternPortal.UI.Controllers
{
    [Authorize]
    public class UserController : BaseController
    {
        public UserController(IInternUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public ActionResult ViewAll()
        {
            return View();
        }

        //interns create and view in edit mode.
        public ActionResult ApplicationUser()
        {
            var aspUser = _unitOfWork.AspNetUsers.Where(i => i.UserName == User.Identity.Name).FirstOrDefault();
            var user = _unitOfWork.Users.Where(i => i.Id == aspUser.Id).FirstOrDefault() ?? new User();

            return View(user);
        }

        [HttpPost]
        public ActionResult SaveUser(User model)
        {
            if (!ModelState.IsValid)
            {
                return View("ApplicationUser", model);
            }

            //add or update user
            var userToSave = _unitOfWork.Users.Where(i => i.UserId == model.UserId).FirstOrDefault();

            if (userToSave != null)
            {
                _unitOfWork.Context().Entry(userToSave).CurrentValues.SetValues(model);
            }
            else
            {
                var aspUser = _unitOfWork.AspNetUsers.Where(i => i.UserName == User.Identity.Name).FirstOrDefault();

                model.Id = aspUser.Id;

                _unitOfWork.Users.Add(model);
            }
            _unitOfWork.Complete();

            return View("ApplicationUser", model);
        }


        //admins view in display
        public ActionResult ViewUser(int? userId)
        {
            var model = _unitOfWork.Users.Where(u => u.UserId == userId).FirstOrDefault();

            if (model == null)
            {
                ModelState.AddModelError(string.Empty, "User Not Found");
                return View(model);
            }

            return View(model);
        }

        //admins can soft delete
        public ActionResult DeleteUser()
        {
            return View();
        }

    }
}
