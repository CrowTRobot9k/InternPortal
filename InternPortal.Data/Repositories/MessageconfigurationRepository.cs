             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class MessageconfigurationRepository : Repository<MessageConfiguration>, IMessageconfigurationRepository
	{

		public MessageconfigurationRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IMessageconfigurationRepository.cs file
	}
}
