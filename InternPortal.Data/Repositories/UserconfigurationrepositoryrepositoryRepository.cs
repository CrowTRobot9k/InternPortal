             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class UserconfigurationrepositoryrepositoryRepository : Repository<UserconfigurationrepositoryRepository>, IUserconfigurationrepositoryrepositoryRepository
	{

		public UserconfigurationrepositoryrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IUserconfigurationrepositoryrepositoryRepository.cs file
	}
}
