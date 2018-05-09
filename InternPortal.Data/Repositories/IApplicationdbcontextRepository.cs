
using InternPortal.Data.Models;
using InternPortal.Data;

namespace InternPortal.Data.Models
{
	public interface IApplicationdbcontextRepository : IRepository<ApplicationDbContext>
	{
		//Add any additional repository methods other than the generic ones (GetAll, GetById, Delete, Add)
	}
}
