             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class QuestionoptionrepositoryRepository : Repository<QuestionoptionRepository>, IQuestionoptionrepositoryRepository
	{

		public QuestionoptionrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IQuestionoptionrepositoryRepository.cs file
	}
}
