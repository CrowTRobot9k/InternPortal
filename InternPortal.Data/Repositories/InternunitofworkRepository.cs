             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class InternunitofworkRepository : Repository<InternUnitOfWork>, IInternunitofworkRepository
	{

		public InternunitofworkRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IInternunitofworkRepository.cs file
	}
}
