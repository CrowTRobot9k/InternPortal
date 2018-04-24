             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class UseruploadRepository : Repository<UserUpload>, IUseruploadRepository
	{

		public UseruploadRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IUseruploadRepository.cs file
	}
}
