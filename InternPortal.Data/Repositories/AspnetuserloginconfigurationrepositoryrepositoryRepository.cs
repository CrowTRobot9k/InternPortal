             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class AspnetuserloginconfigurationrepositoryrepositoryRepository : Repository<AspnetuserloginconfigurationrepositoryRepository>, IAspnetuserloginconfigurationrepositoryrepositoryRepository
	{

		public AspnetuserloginconfigurationrepositoryrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IAspnetuserloginconfigurationrepositoryrepositoryRepository.cs file
	}
}
