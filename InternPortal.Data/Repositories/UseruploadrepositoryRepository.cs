             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class UseruploadrepositoryRepository : Repository<UseruploadRepository>, IUseruploadrepositoryRepository
	{

		public UseruploadrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IUseruploadrepositoryRepository.cs file
	}
}
