             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class AspnetrolerepositoryrepositoryRepository : Repository<AspnetrolerepositoryRepository>, IAspnetrolerepositoryrepositoryRepository
	{

		public AspnetrolerepositoryrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IAspnetrolerepositoryrepositoryRepository.cs file
	}
}
