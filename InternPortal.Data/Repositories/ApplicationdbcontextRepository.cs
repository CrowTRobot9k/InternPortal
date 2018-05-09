             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class ApplicationdbcontextRepository : Repository<ApplicationDbContext>, IApplicationdbcontextRepository
	{

		public ApplicationdbcontextRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IApplicationdbcontextRepository.cs file
	}
}
