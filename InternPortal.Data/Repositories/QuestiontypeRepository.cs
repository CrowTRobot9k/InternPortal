             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class QuestiontypeRepository : Repository<QuestionType>, IQuestiontypeRepository
	{

		public QuestiontypeRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IQuestiontypeRepository.cs file
	}
}
