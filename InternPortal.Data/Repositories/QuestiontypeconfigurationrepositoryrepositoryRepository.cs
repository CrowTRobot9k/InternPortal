             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class QuestiontypeconfigurationrepositoryrepositoryRepository : Repository<QuestiontypeconfigurationrepositoryRepository>, IQuestiontypeconfigurationrepositoryrepositoryRepository
	{

		public QuestiontypeconfigurationrepositoryrepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IQuestiontypeconfigurationrepositoryrepositoryRepository.cs file
	}
}
