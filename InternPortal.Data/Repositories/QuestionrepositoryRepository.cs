             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class QuestionrepositoryRepository : Repository<QuestionRepository>, IQuestionrepositoryRepository
	{

		public QuestionrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IQuestionrepositoryRepository.cs file
	}
}
