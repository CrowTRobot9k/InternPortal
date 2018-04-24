             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class AspnetuserclaimRepository : Repository<AspNetUserClaim>, IAspnetuserclaimRepository
	{

		public AspnetuserclaimRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IAspnetuserclaimRepository.cs file
	}
}
