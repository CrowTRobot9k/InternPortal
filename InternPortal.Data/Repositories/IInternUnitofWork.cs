            using System;
using InternPortal.Data.Models;
using InternPortal.Data;

namespace InternPortal.Data.Models
{
	public interface IInternUnitOfWork : IUnitOfWork
	{
			IAspnetuserloginconfigurationRepository AspNetUserLoginConfigurations { get; }
			IAspnetuserclaimconfigurationRepository AspNetUserClaimConfigurations { get; }
			IAspnetuserconfigurationRepository AspNetUserConfigurations { get; }
			IAspnetroleconfigurationRepository AspNetRoleConfigurations { get; }
			IAspnetuserloginRepository AspNetUserLogins { get; }
			IAspnetuserclaimRepository AspNetUserClaims { get; }
			IAspnetuserRepository AspNetUsers { get; }
			IAspnetroleRepository AspNetRoles { get; }
			IInternportalcontextfactoryRepository InternPortalContextFactorys { get; }
			IAspnetuserloginconfigurationrepositoryRepository AspnetuserloginconfigurationRepositorys { get; }
			IAspnetuserclaimconfigurationrepositoryRepository AspnetuserclaimconfigurationRepositorys { get; }
			IAspnetuserconfigurationrepositoryRepository AspnetuserconfigurationRepositorys { get; }
			IAspnetroleconfigurationrepositoryRepository AspnetroleconfigurationRepositorys { get; }
			IAspnetuserloginrepositoryRepository AspnetuserloginRepositorys { get; }
			IAspnetuserclaimrepositoryRepository AspnetuserclaimRepositorys { get; }
			IAspnetuserrepositoryRepository AspnetuserRepositorys { get; }
			IAspnetrolerepositoryRepository AspnetroleRepositorys { get; }
			IInternportalcontextfactoryrepositoryRepository InternportalcontextfactoryRepositorys { get; }
			IInternunitofworkRepository InternUnitOfWorks { get; }
			IUseruploadconfigurationRepository UserUploadConfigurations { get; }
			IUserconfigurationRepository UserConfigurations { get; }
			IQuestiontypeconfigurationRepository QuestionTypeConfigurations { get; }
			IQuestionoptionconfigurationRepository QuestionOptionConfigurations { get; }
			IQuestionconfigurationRepository QuestionConfigurations { get; }
			IMessageconfigurationRepository MessageConfigurations { get; }
			IApplicationstatuconfigurationRepository ApplicationStatuConfigurations { get; }
			IApplicationconfigurationRepository ApplicationConfigurations { get; }
			IAnswerconfigurationRepository AnswerConfigurations { get; }
			IUseruploadRepository UserUploads { get; }
			IUserRepository Users { get; }
			IQuestiontypeRepository QuestionTypes { get; }
			IQuestionoptionRepository QuestionOptions { get; }
			IQuestionRepository Questions { get; }
			IMessageRepository Messages { get; }
			IApplicationstatuRepository ApplicationStatus { get; }
			IApplicationRepository Applications { get; }
			IAnswerRepository Answers { get; }
			
	//Change this to the context type
	IInternPortalContext Context();
	void Complete();

	}
}
