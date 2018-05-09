             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class MessageconfigurationrepositoryRepository : Repository<MessageconfigurationRepository>, IMessageconfigurationrepositoryRepository
	{

		public MessageconfigurationrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IMessageconfigurationrepositoryRepository.cs file
	}
}
