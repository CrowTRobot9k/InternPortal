             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class ApplicationconfigurationrepositoryRepository : Repository<ApplicationconfigurationRepository>, IApplicationconfigurationrepositoryRepository
	{

		public ApplicationconfigurationrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IApplicationconfigurationrepositoryRepository.cs file
	}
}
