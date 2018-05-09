using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using InternPortal.Data.Models;
using InternPortal.UI.App_Start;
using InternPortal.UI.Dto;

namespace InternPortal.UI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            Mapper.Initialize(cfg =>
            {
                //Create Mappings here;
                //example cfg.CreateMap<Entity,EntityDto>();
                cfg.CreateMap<User, UserDto>();
                cfg.CreateMap<UserDto, User>();

                cfg.CreateMap<Application, ApplicationDto>();
                cfg.CreateMap<ApplicationDto, Application>();

                cfg.CreateMap<Question, QuestionDto>();
                cfg.CreateMap<QuestionDto, Question>();

                cfg.CreateMap<QuestionOption, QuestionOptionDto>();
                cfg.CreateMap<QuestionOptionDto, QuestionOption>();

                cfg.CreateMap<Answer, AnswerDto>();
                cfg.CreateMap<AnswerDto, Answer>();

                cfg.CreateMap<Message, MessageDto>();
                cfg.CreateMap<MessageDto, Message>();

                cfg.CreateMap<QuestionType, QuestionTypeDto>();
                cfg.CreateMap<QuestionTypeDto, QuestionType>();

                cfg.CreateMap<UserUpload, UserUploadDto>();
                cfg.CreateMap<UserUploadDto, UserUpload>();

                cfg.CreateMap<Application, ApplicationChildUserDto>();
                cfg.CreateMap<ApplicationChildUserDto, Application>();

                cfg.CreateMap<User,UserNoAppDto>();
                cfg.CreateMap<UserNoAppDto, User>();

                cfg.CreateMap<ApplicationStatu, ApplicationStatusDto>();
                cfg.CreateMap<ApplicationStatusDto, ApplicationStatu>();

                cfg.CreateMap<Note,NoteDto>();
                cfg.CreateMap<NoteDto, Note>();

                cfg.CreateMap<AspNetUser, AspNetUserDto>();
                cfg.CreateMap<AspNetUserDto, AspNetUser>();
            });

        }
    }
}
