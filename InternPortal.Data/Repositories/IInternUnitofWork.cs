            using System;
using InternPortal.Data.Models;
using InternPortal.Data;

namespace InternPortal.Data.Models
{
	public interface IInternUnitOfWork : IUnitOfWork
	{
			IAspnetuserloginrepositoryrepositoryRepository AspnetuserloginrepositoryRepositorys { get; }
			IQuestionoptionconfigurationRepository QuestionOptionConfigurations { get; }
			IAspnetuserclaimconfigurationRepository AspNetUserClaimConfigurations { get; }
			IAspnetuserRepository AspNetUsers { get; }
			IQuestiontyperepositoryRepository QuestiontypeRepositorys { get; }
			IAspnetuserrepositoryrepositoryRepository AspnetuserrepositoryRepositorys { get; }
			IUseruploadconfigurationRepository UserUploadConfigurations { get; }
			IQuestionconfigurationRepository QuestionConfigurations { get; }
			IAspnetuserloginRepository AspNetUserLogins { get; }
			IAspnetuserconfigurationRepository AspNetUserConfigurations { get; }
			IUserrepositoryRepository UserRepositorys { get; }
			IQuestionrepositoryRepository QuestionRepositorys { get; }
			IMessageconfigurationrepositoryRepository MessageconfigurationRepositorys { get; }
			IAspnetuserloginconfigurationRepository AspNetUserLoginConfigurations { get; }
			IAspnetuserclaimRepository AspNetUserClaims { get; }
			IInternportalcontextfactoryrepositoryRepository InternportalcontextfactoryRepositorys { get; }
			IAspnetuserclaimconfigurationrepositoryRepository AspnetuserclaimconfigurationRepositorys { get; }
			IQuestionoptionconfigurationrepositoryRepository QuestionoptionconfigurationRepositorys { get; }
			IQuestionconfigurationrepositoryRepository QuestionconfigurationRepositorys { get; }
			IAnswerrepositoryRepository AnswerRepositorys { get; }
			IUseruploadRepository UserUploads { get; }
			IMessageRepository Messages { get; }
			IAspnetuserloginconfigurationrepositoryRepository AspnetuserloginconfigurationRepositorys { get; }
			IAspnetuserconfigurationrepositoryRepository AspnetuserconfigurationRepositorys { get; }
			IAspnetrolerepositoryRepository AspnetroleRepositorys { get; }
			IAspnetroleconfigurationrepositoryrepositoryRepository AspnetroleconfigurationrepositoryRepositorys { get; }
			IAspnetroleRepository AspNetRoles { get; }
			IInternunitofworkrepositoryRepository InternunitofworkRepositorys { get; }
			IAnswerconfigurationrepositoryRepository AnswerconfigurationRepositorys { get; }
			IAnswerRepository Answers { get; }
			IQuestionoptionrepositoryRepository QuestionoptionRepositorys { get; }
			IInternportalcontextfactoryrepositoryrepositoryRepository InternportalcontextfactoryrepositoryRepositorys { get; }
			IAspnetuserrepositoryRepository AspnetuserRepositorys { get; }
			IQuestiontypeRepository QuestionTypes { get; }
			IAnswerconfigurationRepository AnswerConfigurations { get; }
			IAspnetuserclaimrepositoryrepositoryRepository AspnetuserclaimrepositoryRepositorys { get; }
			IQuestiontypeconfigurationRepository QuestionTypeConfigurations { get; }
			IApplicationstatuRepository ApplicationStatus { get; }
			IUseruploadrepositoryRepository UseruploadRepositorys { get; }
			IUseruploadconfigurationrepositoryRepository UseruploadconfigurationRepositorys { get; }
			IQuestionoptionRepository QuestionOptions { get; }
			IQuestionRepository Questions { get; }
			IInternportalcontextfactoryRepository InternPortalContextFactorys { get; }
			IUserconfigurationrepositoryRepository UserconfigurationRepositorys { get; }
			IQuestiontypeconfigurationrepositoryRepository QuestiontypeconfigurationRepositorys { get; }
			IInternunitofworkRepository InternUnitOfWorks { get; }
			IAspnetuserloginconfigurationrepositoryrepositoryRepository AspnetuserloginconfigurationrepositoryRepositorys { get; }
			IAspnetuserconfigurationrepositoryrepositoryRepository AspnetuserconfigurationrepositoryRepositorys { get; }
			IAspnetrolerepositoryrepositoryRepository AspnetrolerepositoryRepositorys { get; }
			IAspnetroleconfigurationrepositoryRepository AspnetroleconfigurationRepositorys { get; }
			IApplicationstatuconfigurationrepositoryRepository ApplicationstatuconfigurationRepositorys { get; }
			IUserconfigurationRepository UserConfigurations { get; }
			IMessagerepositoryRepository MessageRepositorys { get; }
			IAspnetuserclaimrepositoryRepository AspnetuserclaimRepositorys { get; }
			IUserRepository Users { get; }
			IAspnetuserloginrepositoryRepository AspnetuserloginRepositorys { get; }
			IAspnetuserclaimconfigurationrepositoryrepositoryRepository AspnetuserclaimconfigurationrepositoryRepositorys { get; }
			IMessageconfigurationRepository MessageConfigurations { get; }
			IApplicationconfigurationRepository ApplicationConfigurations { get; }
			IApplicationuserRepository ApplicationUsers { get; }
			IApplicationdbcontextRepository ApplicationDbContexts { get; }
			IAspnetroleconfigurationRepository AspNetRoleConfigurations { get; }
			IApplicationstaturepositoryRepository ApplicationstatuRepositorys { get; }
			IApplicationrepositoryRepository ApplicationRepositorys { get; }
			IApplicationconfigurationrepositoryRepository ApplicationconfigurationRepositorys { get; }
			IApplicationRepository Applications { get; }
			IApplicationstatuconfigurationRepository ApplicationStatuConfigurations { get; }
			INoteconfigurationRepository NoteConfigurations { get; }
			INoteRepository Notes { get; }
			
	//Change this to the context type
	IInternPortalContext Context();
	void Complete();

	}
}
