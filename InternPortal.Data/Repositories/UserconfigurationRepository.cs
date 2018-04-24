             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class UserconfigurationRepository : Repository<UserConfiguration>, IUserconfigurationRepository
	{

		public UserconfigurationRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IUserconfigurationRepository.cs file
	}
}
