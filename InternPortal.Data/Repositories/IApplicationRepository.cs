
using InternPortal.Data.Models;
using InternPortal.Data;
using System.Collections.Generic;

namespace InternPortal.Data.Models
{
	public interface IApplicationRepository : IRepository<Application>
	{
        //Add any additional repository methods other than the generic ones (GetAll, GetById, Delete, Add)
        Application UpdateApplicationAnswers(Application application, IEnumerable<Question> questions);

        Application UpdateApplicationUploads(Application application, IEnumerable<UserUpload> uploads);
    }
}
