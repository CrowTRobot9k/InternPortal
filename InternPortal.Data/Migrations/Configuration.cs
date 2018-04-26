namespace InternPortal.Data.Migrations
{
    using InternPortal.Data.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.AspNet.Identity;
    using InternPortal.Data;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<InternPortal.Data.Models.InternPortalContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(InternPortal.Data.Models.InternPortalContext context)
        {
            SeedRoles(context);

            SeedUsers(context);

            SeedApplicationStatus(context);

            SeedQuestionType(context);
        }

        private void SeedRoles(IInternPortalContext context)
        {
            var appContext = new ApplicationDbContext();

            var roleStore = new RoleStore<IdentityRole>(appContext);
            var roleManager = new RoleManager<IdentityRole>(roleStore);

            roleManager.Create(new IdentityRole { Name = "admin" });
            roleManager.Create(new IdentityRole { Name = "intern" });
        }

        private void SeedUsers(IInternPortalContext context)
        {
            var appContext = new ApplicationDbContext();
            var userStore = new UserStore<ApplicationUser>(appContext);
            var userManager = new UserManager<ApplicationUser>(userStore);

            var roleStore = new RoleStore<IdentityRole>(appContext);
            var roleManager = new RoleManager<IdentityRole>(roleStore);

            if (!context.AspNetUsers.Any(u => u.Email == "peteramathieu@gmail.com"))
            {
                var user = new ApplicationUser { UserName = "peteramathieu@gmail.com",Email= "peteramathieu@gmail.com" };

                userManager.Create(user, "p@ssw0rd");
                userManager.AddToRole(user.Id, "admin");
            }

            if (!context.AspNetUsers.Any(u => u.Email == "peter_mathieu@yahoo.com"))
            {
                var user = new ApplicationUser { UserName = "peter_mathieu@yahoo.com", Email = "peter_mathieu@yahoo.com" };

                userManager.Create(user, "p@ssw0rd");
                userManager.AddToRole(user.Id, "intern");
            }

        }

        private void SeedApplicationStatus(IInternPortalContext context)
        {
            context.ApplicationStatus.AddOrUpdate(a => a.Status,
                new ApplicationStatu { ApplicationStatusId = 1, Status = "Pending" },
                new ApplicationStatu { ApplicationStatusId = 2, Status = "Reviewed" },
                new ApplicationStatu { ApplicationStatusId = 3, Status = "PhoneInterviewed" },
                new ApplicationStatu { ApplicationStatusId = 4, Status = "InPersonInterviewed" },
                new ApplicationStatu { ApplicationStatusId = 5, Status = "OfferExtended" },
                new ApplicationStatu { ApplicationStatusId = 6, Status = "Hired" },
                new ApplicationStatu { ApplicationStatusId = 7, Status = "Rejected" });
        }

        private void SeedQuestionType(IInternPortalContext context)
        {
            context.QuestionTypes.AddOrUpdate(q => q.QuestionType_,
                new QuestionType { QuestionTypeId = 1, QuestionType_ = "TextBox" },
                new QuestionType { QuestionTypeId = 2, QuestionType_ = "TextArea" },
                new QuestionType { QuestionTypeId = 3, QuestionType_ = "RadioButton" },
                new QuestionType { QuestionTypeId = 4, QuestionType_ = "Checkbox" },
                new QuestionType { QuestionTypeId = 5, QuestionType_ = "DropDown" },
                new QuestionType { QuestionTypeId = 6, QuestionType_ = "Date" },
                new QuestionType { QuestionTypeId = 7, QuestionType_ ="Numeric"});
        }

        private void SeedQuestions()
        {
            var textBox = new Question()
            {
                QuestionType = (int)InternPortal.Data.Constants.QuestionType.TextBox,
                Question_ = "Question1"
            };

            var textArea = new Question()
            {
                QuestionType = (int)InternPortal.Data.Constants.QuestionType.TextArea,
                Question_ = "Question2"
            };

            var dropDown = new Question()
            {
                QuestionType = (int)InternPortal.Data.Constants.QuestionType.DropDown,
                Question_ = "Question3"
            };

            dropDown.QuestionOptions = new List<QuestionOption>()
            {
                new QuestionOption()
                {
                    Question = dropDown,
                    OptionValue = "Option1",

                },
                new QuestionOption()
                {
                    Question = dropDown,
                    OptionValue = "Option2",

                }
            };

            var radioButton = new Question()
            {
                QuestionType = (int)InternPortal.Data.Constants.QuestionType.RadioButton,
                Question_ = "",

            };

            radioButton.QuestionOptions = new List<QuestionOption>()
            {
                new QuestionOption()
                {
                    Question = radioButton,
                    OptionValue = "",
                    
                },
                new QuestionOption()
                {
                    Question = radioButton,
                    OptionValue = "",

                }
            };

            var checkBox = new Question()
            {
                QuestionType = (int)InternPortal.Data.Constants.QuestionType.Checkbox,
                Question_ = ""
            };

            checkBox.QuestionOptions = new List<QuestionOption>()
            {
                new QuestionOption()
                {
                    Question = checkBox,
                    OptionValue = "",

                },
                new QuestionOption()
                {
                    Question = checkBox,
                    OptionValue = "",

                }
            };

            var date = new Question()
            {
                QuestionType = (int)InternPortal.Data.Constants.QuestionType.Date,
                Question_ = ""
            };

            var numeric = new Question()
            {
                QuestionType = (int)InternPortal.Data.Constants.QuestionType.Numeric,
                Question_ = ""
            };
        }
    }
}
