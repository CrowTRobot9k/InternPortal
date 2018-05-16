using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternPortal.UI.Dto
{
    public class ApplicationDto
    {
        public int ApplicationId { get; set; } // ApplicationId (Primary key)
        public int UserId { get; set; } // UserId
        public int? PositionId { get; set; } // PositionId
        public System.DateTime? ApplicationStartDate { get; set; } // ApplicationStartDate
        public System.DateTime? ApplicationCompleteDate { get; set; } // ApplicationCompleteDate
        public int? ApplicationStatusId { get; set; } // ApplicationStatus

        public List<NoteDto> Notes { get; set; } // Note.FK_Note_Application
        public ApplicationStatusDto ApplicationStatu { get; set; } // FK_Application_ApplicationStatus
        public List<AnswerDto> Answers { get; set; } // Answers.FK_dbo.Answers_dbo.Application_ApplicationId
        public List<UserUploadDto> UserUploads { get; set; } // UserUploads.FK_dbo.UserUploads_dbo.Application_ApplicationId
        public UserDto User { get; set; } // FK_dbo.Application_dbo.User_UserId
        public PositionDto Position { get; set; } // FK_Application_Position
    }
}