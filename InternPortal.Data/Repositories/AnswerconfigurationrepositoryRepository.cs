             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class AnswerconfigurationrepositoryRepository : Repository<AnswerconfigurationRepository>, IAnswerconfigurationrepositoryRepository
	{

		public AnswerconfigurationrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IAnswerconfigurationrepositoryRepository.cs file
	}
}
