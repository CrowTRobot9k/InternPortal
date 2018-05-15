             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class UseruploadrepositoryrepositoryRepository : Repository<UseruploadrepositoryRepository>, IUseruploadrepositoryrepositoryRepository
	{

		public UseruploadrepositoryrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IUseruploadrepositoryrepositoryRepository.cs file
	}
}
