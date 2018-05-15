             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class ApplicationuserrepositoryRepository : Repository<ApplicationuserRepository>, IApplicationuserrepositoryRepository
	{

		public ApplicationuserrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IApplicationuserrepositoryRepository.cs file
	}
}
