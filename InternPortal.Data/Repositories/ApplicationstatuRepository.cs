             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class ApplicationstatuRepository : Repository<ApplicationStatu>, IApplicationstatuRepository
	{

		public ApplicationstatuRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IApplicationstatuRepository.cs file
	}
}
