             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class QuestionoptionRepository : Repository<QuestionOption>, IQuestionoptionRepository
	{

		public QuestionoptionRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IQuestionoptionRepository.cs file
	}
}
