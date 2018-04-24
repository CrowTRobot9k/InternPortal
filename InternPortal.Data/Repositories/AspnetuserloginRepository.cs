             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class AspnetuserloginRepository : Repository<AspNetUserLogin>, IAspnetuserloginRepository
	{

		public AspnetuserloginRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IAspnetuserloginRepository.cs file
	}
}
