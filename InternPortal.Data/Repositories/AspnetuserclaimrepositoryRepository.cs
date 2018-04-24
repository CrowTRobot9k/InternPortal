             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class AspnetuserclaimrepositoryRepository : Repository<AspnetuserclaimRepository>, IAspnetuserclaimrepositoryRepository
	{

		public AspnetuserclaimrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IAspnetuserclaimrepositoryRepository.cs file
	}
}
