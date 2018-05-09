             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class AspnetroleconfigurationrepositoryrepositoryRepository : Repository<AspnetroleconfigurationrepositoryRepository>, IAspnetroleconfigurationrepositoryrepositoryRepository
	{

		public AspnetroleconfigurationrepositoryrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IAspnetroleconfigurationrepositoryrepositoryRepository.cs file
	}
}
