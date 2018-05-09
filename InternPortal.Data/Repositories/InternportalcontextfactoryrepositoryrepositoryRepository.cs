             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class InternportalcontextfactoryrepositoryrepositoryRepository : Repository<InternportalcontextfactoryrepositoryRepository>, IInternportalcontextfactoryrepositoryrepositoryRepository
	{

		public InternportalcontextfactoryrepositoryrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IInternportalcontextfactoryrepositoryrepositoryRepository.cs file
	}
}
