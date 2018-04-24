             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class AspnetuserrepositoryRepository : Repository<AspnetuserRepository>, IAspnetuserrepositoryRepository
	{

		public AspnetuserrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IAspnetuserrepositoryRepository.cs file
	}
}
