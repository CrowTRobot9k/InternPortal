             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class QuestionoptionconfigurationrepositoryRepository : Repository<QuestionoptionconfigurationRepository>, IQuestionoptionconfigurationrepositoryRepository
	{

		public QuestionoptionconfigurationrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IQuestionoptionconfigurationrepositoryRepository.cs file
	}
}
