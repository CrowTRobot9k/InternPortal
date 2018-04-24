             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class AspnetuserclaimconfigurationrepositoryRepository : Repository<AspnetuserclaimconfigurationRepository>, IAspnetuserclaimconfigurationrepositoryRepository
	{

		public AspnetuserclaimconfigurationrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IAspnetuserclaimconfigurationrepositoryRepository.cs file
	}
}
