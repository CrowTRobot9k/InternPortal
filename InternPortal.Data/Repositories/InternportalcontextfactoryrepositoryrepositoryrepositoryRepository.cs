             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class InternportalcontextfactoryrepositoryrepositoryrepositoryRepository : Repository<InternportalcontextfactoryrepositoryrepositoryRepository>, IInternportalcontextfactoryrepositoryrepositoryrepositoryRepository
	{

		public InternportalcontextfactoryrepositoryrepositoryrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IInternportalcontextfactoryrepositoryrepositoryrepositoryRepository.cs file
	}
}
