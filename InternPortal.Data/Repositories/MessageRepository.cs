             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class MessageRepository : Repository<Message>, IMessageRepository
	{

		public MessageRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IMessageRepository.cs file
	}
}
