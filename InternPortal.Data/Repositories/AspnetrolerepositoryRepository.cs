             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class AspnetrolerepositoryRepository : Repository<AspnetroleRepository>, IAspnetrolerepositoryRepository
	{

		public AspnetrolerepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IAspnetrolerepositoryRepository.cs file
	}
}
