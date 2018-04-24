             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class AspnetroleconfigurationrepositoryRepository : Repository<AspnetroleconfigurationRepository>, IAspnetroleconfigurationrepositoryRepository
	{

		public AspnetroleconfigurationrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IAspnetroleconfigurationrepositoryRepository.cs file
	}
}
