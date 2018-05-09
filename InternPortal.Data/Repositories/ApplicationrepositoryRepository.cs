             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class ApplicationrepositoryRepository : Repository<ApplicationRepository>, IApplicationrepositoryRepository
	{

		public ApplicationrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IApplicationrepositoryRepository.cs file
	}
}
