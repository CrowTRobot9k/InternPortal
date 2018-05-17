             
using InternPortal.Data;		   
using InternPortal.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace InternPortal.Data.Models
{          
	public class MessageRepository : Repository<Message>, IMessageRepository
	{

		public MessageRepository(IInternPortalContext context) : base(context)
		{

		}

        //Override any generic method for your own custom implemention, add new repository methods to the IMessageRepository.cs file
        public IEnumerable<AspNetUser> GetConversations(AspNetUser userLoggedIn)
        {
            var receivedMessages = _context.Messages.Where(m => m.UserIdTo == userLoggedIn.Id).Select(u => u.AspNetUser_UserIdFrom).ToList();
            var sentMessages = _context.Messages.Where(m => m.UserIdFrom == userLoggedIn.Id).Select(u => u.AspNetUser_UserIdTo).ToList();

            var userConversations = new List<AspNetUser>();

            userConversations.AddRange(receivedMessages);
            userConversations.AddRange(sentMessages);

            return userConversations;
        }
	}
}
