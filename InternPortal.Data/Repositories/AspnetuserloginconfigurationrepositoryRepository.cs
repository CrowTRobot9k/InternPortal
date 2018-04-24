             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class AspnetuserloginconfigurationrepositoryRepository : Repository<AspnetuserloginconfigurationRepository>, IAspnetuserloginconfigurationrepositoryRepository
	{

		public AspnetuserloginconfigurationrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IAspnetuserloginconfigurationrepositoryRepository.cs file
	}
}
