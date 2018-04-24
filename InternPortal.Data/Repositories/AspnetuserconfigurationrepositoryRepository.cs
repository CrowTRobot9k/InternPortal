             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class AspnetuserconfigurationrepositoryRepository : Repository<AspnetuserconfigurationRepository>, IAspnetuserconfigurationrepositoryRepository
	{

		public AspnetuserconfigurationrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IAspnetuserconfigurationrepositoryRepository.cs file
	}
}
