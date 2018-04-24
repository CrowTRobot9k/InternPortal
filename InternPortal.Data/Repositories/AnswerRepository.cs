             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class AnswerRepository : Repository<Answer>, IAnswerRepository
	{

		public AnswerRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the IAnswerRepository.cs file
	}
}
