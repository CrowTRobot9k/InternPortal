             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class MessageconfigurationrepositoryrepositoryRepository : Repository<MessageconfigurationrepositoryRepository>, IMessageconfigurationrepositoryrepositoryRepository
	{

		public MessageconfigurationrepositoryrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IMessageconfigurationrepositoryrepositoryRepository.cs file
	}
}
