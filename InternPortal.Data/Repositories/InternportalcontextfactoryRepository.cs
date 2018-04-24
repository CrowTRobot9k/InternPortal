             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class InternportalcontextfactoryRepository : Repository<InternPortalContextFactory>, IInternportalcontextfactoryRepository
	{

		public InternportalcontextfactoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IInternportalcontextfactoryRepository.cs file
	}
}
