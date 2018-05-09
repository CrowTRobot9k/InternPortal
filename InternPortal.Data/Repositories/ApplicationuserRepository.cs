             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class ApplicationuserRepository : Repository<ApplicationUser>, IApplicationuserRepository
	{

		public ApplicationuserRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IApplicationuserRepository.cs file
	}
}
