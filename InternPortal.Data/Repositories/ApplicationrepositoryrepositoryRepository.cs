             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class ApplicationrepositoryrepositoryRepository : Repository<ApplicationrepositoryRepository>, IApplicationrepositoryrepositoryRepository
	{

		public ApplicationrepositoryrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IApplicationrepositoryrepositoryRepository.cs file
	}
}
