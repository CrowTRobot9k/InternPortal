             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class QuestionrepositoryrepositoryRepository : Repository<QuestionrepositoryRepository>, IQuestionrepositoryrepositoryRepository
	{

		public QuestionrepositoryrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IQuestionrepositoryrepositoryRepository.cs file
	}
}
