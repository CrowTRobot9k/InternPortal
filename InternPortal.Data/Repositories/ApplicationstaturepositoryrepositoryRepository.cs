             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class ApplicationstaturepositoryrepositoryRepository : Repository<ApplicationstaturepositoryRepository>, IApplicationstaturepositoryrepositoryRepository
	{

		public ApplicationstaturepositoryrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IApplicationstaturepositoryrepositoryRepository.cs file
	}
}
