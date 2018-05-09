             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class QuestiontypeconfigurationrepositoryRepository : Repository<QuestiontypeconfigurationRepository>, IQuestiontypeconfigurationrepositoryRepository
	{

		public QuestiontypeconfigurationrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IQuestiontypeconfigurationrepositoryRepository.cs file
	}
}
