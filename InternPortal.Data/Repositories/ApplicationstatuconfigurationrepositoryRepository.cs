             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class ApplicationstatuconfigurationrepositoryRepository : Repository<ApplicationstatuconfigurationRepository>, IApplicationstatuconfigurationrepositoryRepository
	{

		public ApplicationstatuconfigurationrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IApplicationstatuconfigurationrepositoryRepository.cs file
	}
}
