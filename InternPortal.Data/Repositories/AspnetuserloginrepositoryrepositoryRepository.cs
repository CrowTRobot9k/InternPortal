             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class AspnetuserloginrepositoryrepositoryRepository : Repository<AspnetuserloginrepositoryRepository>, IAspnetuserloginrepositoryrepositoryRepository
	{

		public AspnetuserloginrepositoryrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IAspnetuserloginrepositoryrepositoryRepository.cs file
	}
}
