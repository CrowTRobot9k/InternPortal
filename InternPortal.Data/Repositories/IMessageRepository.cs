
using InternPortal.Data.Models;
using InternPortal.Data;

namespace InternPortal.Data.Models
{
	public interface IMessageRepository : IRepository<Message>
	{
		//Add any additional repository methods other than the generic ones (GetAll, GetById, Delete, Add)
	}
}
