             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class AspnetroleRepository : Repository<AspNetRole>, IAspnetroleRepository
	{

		public AspnetroleRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IAspnetroleRepository.cs file
	}
}
