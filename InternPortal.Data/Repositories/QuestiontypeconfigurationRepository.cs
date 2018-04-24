             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class QuestiontypeconfigurationRepository : Repository<QuestionTypeConfiguration>, IQuestiontypeconfigurationRepository
	{

		public QuestiontypeconfigurationRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IQuestiontypeconfigurationRepository.cs file
	}
}
