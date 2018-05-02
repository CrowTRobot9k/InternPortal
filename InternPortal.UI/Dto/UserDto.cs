using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternPortal.UI.Dto
{
    public class UserDto
    {
        public int UserId { get; set; } // UserId (Primary key)
        public string Id { get; set; } // Id (length: 128)
        public string FirstName { get; set; } // FirstName (length: 100)
        public string MiddleName { get; set; } // MiddleName (length: 100)
        public string LastName { get; set; } // LastName (length: 100)
        public string PhoneNumber { get; set; } // PhoneNumber (length: 50)
        public string Address { get; set; } // Address
        public string City { get; set; } // City (length: 100)
        public string State { get; set; } // State (length: 100)
        public string ZipCode { get; set; } // ZipCode (length: 10)
        public System.DateTime? DateOfBirth { get; set; } // DateOfBirth
        public string Gender { get; set; } // Gender (length: 50)
        public string Ethnicity { get; set; } // Ethnicity (length: 50)

        // Reverse navigation

        /// <summary>
        /// Child Applications where [Application].[UserId] point to this entity (FK_dbo.Application_dbo.User_UserId)
        /// </summary>
        public List<ApplicationDto> Applications { get; set; } // Application.FK_dbo.Application_dbo.User_UserId
        /// <summary>
        /// Child Messages where [Messages].[UserIdFrom] point to this entity (FK_dbo.Messages_dbo.User_UserIdFrom)
        /// </summary>
        public List<MessageDto> Messages_UserIdFrom { get; set; } // Messages.FK_dbo.Messages_dbo.User_UserIdFrom
        /// <summary>
        /// Child Messages where [Messages].[UserIdTo] point to this entity (FK_dbo.Messages_dbo.User_UserIdTo)
        /// </summary>
        public List<MessageDto> Messages_UserIdTo { get; set; } // Messages.FK_dbo.Messages_dbo.User_UserIdTo
        /// <summary>
        /// Parent (One-to-One) User pointed by [UserUploads].[UploadId] (FK_dbo.UserUploads_dbo.User_UploadId)
        /// </summary>
        public UserUploadDto UserUpload { get; set; } // UserUploads.FK_dbo.UserUploads_dbo.User_UploadId
    }
}