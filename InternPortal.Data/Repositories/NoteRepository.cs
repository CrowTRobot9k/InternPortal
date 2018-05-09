             
using InternPortal.Data;		   
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{          
	public class NoteRepository : Repository<Note>, INoteRepository
	{

		public NoteRepository(IInternPortalContext context) : base(context)
		{

		}

		//Override any generic method for your own custom implemention, add new repository methods to the INoteRepository.cs file
	}
}
