             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class AspnetuserRepository : Repository<AspNetUser>, IAspnetuserRepository
	{

		public AspnetuserRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IAspnetuserRepository.cs file
	}
}
