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

            SeedQuestions(context);
        }

        private static void SeedRoles(IInternPortalContext context)
        {
            var appContext = new ApplicationDbContext();

            var roleStore = new RoleStore<IdentityRole>(appContext);
            var roleManager = new RoleManager<IdentityRole>(roleStore);

            roleManager.Create(new IdentityRole { Name = "admin" });
            roleManager.Create(new IdentityRole { Name = "intern" });
        }

        private static void SeedUsers(IInternPortalContext context)
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

            if (!context.AspNetUsers.Any(u => u.Email == "michaelli@arctrade.com"))
            {
                var user = new ApplicationUser { UserName = "michaelli@arctrade.com", Email = "michaelli@arctrade.com" };

                userManager.Create(user, "p@ssw0rd");
                userManager.AddToRole(user.Id, "admin");
            }

            if (!context.AspNetUsers.Any(u => u.Email == "michaelli@gmail.com"))
            {
                var user = new ApplicationUser { UserName = "michaelli@gmail.com", Email = "michaelli@gmail.com" };

                userManager.Create(user, "p@ssw0rd");
                userManager.AddToRole(user.Id, "intern");
            }


        }

        private static void SeedApplicationStatus(IInternPortalContext context)
        {
            context.ApplicationStatus.AddOrUpdate(a => a.Status,
                new ApplicationStatu { ApplicationStatusId = 1, Status = "Pending" },
                new ApplicationStatu { ApplicationStatusId = 2, Status = "Reviewed" },
                new ApplicationStatu { ApplicationStatusId = 3, Status = "Phone Interviewed" },
                new ApplicationStatu { ApplicationStatusId = 4, Status = "In Person Interviewed" },
                new ApplicationStatu { ApplicationStatusId = 5, Status = "Offer Extended" },
                new ApplicationStatu { ApplicationStatusId = 6, Status = "Hired" },
                new ApplicationStatu { ApplicationStatusId = 7, Status = "Rejected" });
        }

        private static void SeedQuestionType(IInternPortalContext context)
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

        private static void SeedQuestions(IInternPortalContext context)
        {
            
            var textBox = new Question()
            {
                QuestionTypeId = (int)InternPortal.Data.Constants.QuestionType.TextBox,
                Question_ = "Question1"
            };

            var textArea = new Question()
            {
                QuestionTypeId = (int)InternPortal.Data.Constants.QuestionType.TextArea,
                Question_ = "Question2"
            };

            var dropDown = new Question()
            {
                QuestionTypeId = (int)InternPortal.Data.Constants.QuestionType.DropDown,
                Question_ = "Question3"
            };

            dropDown.QuestionOptions.Add(
                new QuestionOption()
                {
                    OptionValue = "Option1"
                }
            );

            dropDown.QuestionOptions.Add(
                new QuestionOption()
                {
                    OptionValue = "Option2"
                }
            );

            var radioButton = new Question()
            {
                QuestionTypeId = (int)InternPortal.Data.Constants.QuestionType.RadioButton,
                Question_ = "RadioButton"
            };

            radioButton.QuestionOptions.Add(
                new QuestionOption()
                {
                    OptionValue = "Radiobutton Option 1"          
                });

            radioButton.QuestionOptions.Add(
                new QuestionOption()
                {
                    OptionValue = "Radiobutton Option 2"
                }
            );

            var checkBox = new Question()
            {
                QuestionTypeId = (int)InternPortal.Data.Constants.QuestionType.Checkbox,
                Question_ = "Check Box"
            };

            checkBox.QuestionOptions.Add(
                new QuestionOption()
                {
                    OptionValue = "Checkbox Option 1"
                }
             );

            checkBox.QuestionOptions.Add(
                new QuestionOption()
                {
                    OptionValue = "Checkbox Option 2"
                }
            );

            var date = new Question()
            {
                QuestionTypeId = (int)InternPortal.Data.Constants.QuestionType.Date,
                Question_ = "Date"
            };

            var numeric = new Question()
            {
                QuestionTypeId = (int)InternPortal.Data.Constants.QuestionType.Numeric,
                Question_ = "Numeric"
            };

            context.Questions.AddOrUpdate(q=>q.Question_ ,
                textBox,
                textArea,
                dropDown,
                radioButton,
                checkBox,
                date,
                numeric
            );
        }

        
    }
}
