             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class ApplicationstatuconfigurationrepositoryrepositoryRepository : Repository<ApplicationstatuconfigurationrepositoryRepository>, IApplicationstatuconfigurationrepositoryrepositoryRepository
	{

		public ApplicationstatuconfigurationrepositoryrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IApplicationstatuconfigurationrepositoryrepositoryRepository.cs file
	}
}
