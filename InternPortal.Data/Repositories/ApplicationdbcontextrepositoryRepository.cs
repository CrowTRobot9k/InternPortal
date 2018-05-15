             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class ApplicationdbcontextrepositoryRepository : Repository<ApplicationdbcontextRepository>, IApplicationdbcontextrepositoryRepository
	{

		public ApplicationdbcontextrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IApplicationdbcontextrepositoryRepository.cs file
	}
}
