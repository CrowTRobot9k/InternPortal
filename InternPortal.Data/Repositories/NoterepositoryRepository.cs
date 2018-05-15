             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class NoterepositoryRepository : Repository<NoteRepository>, INoterepositoryRepository
	{

		public NoterepositoryRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the INoterepositoryRepository.cs file
	}
}
