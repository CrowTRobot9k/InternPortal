             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class QuestionconfigurationrepositoryrepositoryRepository : Repository<QuestionconfigurationrepositoryRepository>, IQuestionconfigurationrepositoryrepositoryRepository
	{

		public QuestionconfigurationrepositoryrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IQuestionconfigurationrepositoryrepositoryRepository.cs file
	}
}
