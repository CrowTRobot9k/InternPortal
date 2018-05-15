             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class AnswerconfigurationrepositoryrepositoryRepository : Repository<AnswerconfigurationrepositoryRepository>, IAnswerconfigurationrepositoryrepositoryRepository
	{

		public AnswerconfigurationrepositoryrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IAnswerconfigurationrepositoryrepositoryRepository.cs file
	}
}
