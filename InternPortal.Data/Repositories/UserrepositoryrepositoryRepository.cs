             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class UserrepositoryrepositoryRepository : Repository<UserrepositoryRepository>, IUserrepositoryrepositoryRepository
	{

		public UserrepositoryrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IUserrepositoryrepositoryRepository.cs file
	}
}
