             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class QuestionoptionconfigurationrepositoryrepositoryRepository : Repository<QuestionoptionconfigurationrepositoryRepository>, IQuestionoptionconfigurationrepositoryrepositoryRepository
	{

		public QuestionoptionconfigurationrepositoryrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IQuestionoptionconfigurationrepositoryrepositoryRepository.cs file
	}
}
