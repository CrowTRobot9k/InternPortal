             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class UserrepositoryRepository : Repository<UserRepository>, IUserrepositoryRepository
	{

		public UserrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IUserrepositoryRepository.cs file
	}
}
