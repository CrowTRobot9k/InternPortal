             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class PositionconfigurationRepository : Repository<PositionConfiguration>, IPositionconfigurationRepository
	{

		public PositionconfigurationRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IPositionconfigurationRepository.cs file
	}
}
