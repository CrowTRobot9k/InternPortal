             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class AspnetuserconfigurationRepository : Repository<AspNetUserConfiguration>, IAspnetuserconfigurationRepository
	{

		public AspnetuserconfigurationRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IAspnetuserconfigurationRepository.cs file
	}
}
