             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class UserconfigurationrepositoryRepository : Repository<UserconfigurationRepository>, IUserconfigurationrepositoryRepository
	{

		public UserconfigurationrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IUserconfigurationrepositoryRepository.cs file
	}
}
