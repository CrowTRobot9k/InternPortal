             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class AspnetroleconfigurationRepository : Repository<AspNetRoleConfiguration>, IAspnetroleconfigurationRepository
	{

		public AspnetroleconfigurationRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IAspnetroleconfigurationRepository.cs file
	}
}
