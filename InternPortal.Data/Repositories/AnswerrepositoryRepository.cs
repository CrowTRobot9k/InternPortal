             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class AnswerrepositoryRepository : Repository<AnswerRepository>, IAnswerrepositoryRepository
	{

		public AnswerrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IAnswerrepositoryRepository.cs file
	}
}
