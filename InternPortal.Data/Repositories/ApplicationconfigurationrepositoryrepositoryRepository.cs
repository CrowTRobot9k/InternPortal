             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class ApplicationconfigurationrepositoryrepositoryRepository : Repository<ApplicationconfigurationrepositoryRepository>, IApplicationconfigurationrepositoryrepositoryRepository
	{

		public ApplicationconfigurationrepositoryrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IApplicationconfigurationrepositoryrepositoryRepository.cs file
	}
}
