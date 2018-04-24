             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class QuestionoptionconfigurationRepository : Repository<QuestionOptionConfiguration>, IQuestionoptionconfigurationRepository
	{

		public QuestionoptionconfigurationRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IQuestionoptionconfigurationRepository.cs file
	}
}
