             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class NoteconfigurationrepositoryRepository : Repository<NoteconfigurationRepository>, INoteconfigurationrepositoryRepository
	{

		public NoteconfigurationrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the INoteconfigurationrepositoryRepository.cs file
	}
}
