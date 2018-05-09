             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class QuestionconfigurationrepositoryRepository : Repository<QuestionconfigurationRepository>, IQuestionconfigurationrepositoryRepository
	{

		public QuestionconfigurationrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IQuestionconfigurationrepositoryRepository.cs file
	}
}
