             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class QuestiontyperepositoryRepository : Repository<QuestiontypeRepository>, IQuestiontyperepositoryRepository
	{

		public QuestiontyperepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IQuestiontyperepositoryRepository.cs file
	}
}
