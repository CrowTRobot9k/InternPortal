             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class AspnetuserloginconfigurationRepository : Repository<AspNetUserLoginConfiguration>, IAspnetuserloginconfigurationRepository
	{

		public AspnetuserloginconfigurationRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IAspnetuserloginconfigurationRepository.cs file
	}
}
