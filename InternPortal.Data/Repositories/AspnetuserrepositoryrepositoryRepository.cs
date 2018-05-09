             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class AspnetuserrepositoryrepositoryRepository : Repository<AspnetuserrepositoryRepository>, IAspnetuserrepositoryrepositoryRepository
	{

		public AspnetuserrepositoryrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IAspnetuserrepositoryrepositoryRepository.cs file
	}
}
