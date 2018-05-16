             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class InternunitofworkrepositoryrepositoryRepository : Repository<InternunitofworkrepositoryRepository>, IInternunitofworkrepositoryrepositoryRepository
	{

		public InternunitofworkrepositoryrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IInternunitofworkrepositoryrepositoryRepository.cs file
	}
}
