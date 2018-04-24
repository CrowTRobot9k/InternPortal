             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class ApplicationconfigurationRepository : Repository<ApplicationConfiguration>, IApplicationconfigurationRepository
	{

		public ApplicationconfigurationRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IApplicationconfigurationRepository.cs file
	}
}
