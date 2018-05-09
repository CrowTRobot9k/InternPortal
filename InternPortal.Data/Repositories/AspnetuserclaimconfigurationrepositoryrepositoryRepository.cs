             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class AspnetuserclaimconfigurationrepositoryrepositoryRepository : Repository<AspnetuserclaimconfigurationrepositoryRepository>, IAspnetuserclaimconfigurationrepositoryrepositoryRepository
	{

		public AspnetuserclaimconfigurationrepositoryrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IAspnetuserclaimconfigurationrepositoryrepositoryRepository.cs file
	}
}
