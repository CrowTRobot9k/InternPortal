             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class AnswerrepositoryrepositoryRepository : Repository<AnswerrepositoryRepository>, IAnswerrepositoryrepositoryRepository
	{

		public AnswerrepositoryrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IAnswerrepositoryrepositoryRepository.cs file
	}
}
