             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class UseruploadconfigurationRepository : Repository<UserUploadConfiguration>, IUseruploadconfigurationRepository
	{

		public UseruploadconfigurationRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IUseruploadconfigurationRepository.cs file
	}
}
