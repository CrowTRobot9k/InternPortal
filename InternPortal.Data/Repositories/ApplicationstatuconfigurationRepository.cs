             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class ApplicationstatuconfigurationRepository : Repository<ApplicationStatuConfiguration>, IApplicationstatuconfigurationRepository
	{

		public ApplicationstatuconfigurationRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IApplicationstatuconfigurationRepository.cs file
	}
}
