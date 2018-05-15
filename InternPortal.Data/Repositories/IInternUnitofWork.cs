            using System;
using InternPortal.Data.Models;
using InternPortal.Data;

namespace InternPortal.Data.Models
{
	public interface IInternUnitOfWork : IUnitOfWork
	{
			IQuestiontyperepositoryrepositoryRepository QuestiontyperepositoryRepositorys { get; }
			IAspnetuserloginrepositoryrepositoryRepository AspnetuserloginrepositoryRepositorys { get; }
			IAspnetuserclaimconfigurationrepositoryrepositoryrepositoryRepository AspnetuserclaimconfigurationrepositoryrepositoryRepositorys { get; }
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
			IApplicationstatuconfigurationrepositoryrepositoryRepository ApplicationstatuconfigurationrepositoryRepositorys { get; }
			INoteconfigurationRepository NoteConfigurations { get; }
			IAspnetuserloginconfigurationRepository AspNetUserLoginConfigurations { get; }
			IAspnetuserclaimRepository AspNetUserClaims { get; }
			IInternportalcontextfactoryrepositoryRepository InternportalcontextfactoryRepositorys { get; }
			IAspnetuserrepositoryrepositoryrepositoryRepository AspnetuserrepositoryrepositoryRepositorys { get; }
			IAspnetuserconfigurationrepositoryrepositoryrepositoryRepository AspnetuserconfigurationrepositoryrepositoryRepositorys { get; }
			IAspnetuserclaimconfigurationrepositoryRepository AspnetuserclaimconfigurationRepositorys { get; }
			IApplicationrepositoryrepositoryRepository ApplicationrepositoryRepositorys { get; }
			IQuestionoptionconfigurationrepositoryrepositoryRepository QuestionoptionconfigurationrepositoryRepositorys { get; }
			IQuestionoptionconfigurationrepositoryRepository QuestionoptionconfigurationRepositorys { get; }
			IQuestionconfigurationrepositoryRepository QuestionconfigurationRepositorys { get; }
			INoteconfigurationrepositoryRepository NoteconfigurationRepositorys { get; }
			IAspnetuserloginconfigurationrepositoryrepositoryrepositoryRepository AspnetuserloginconfigurationrepositoryrepositoryRepositorys { get; }
			IAnswerrepositoryRepository AnswerRepositorys { get; }
			IUseruploadRepository UserUploads { get; }
			IMessageRepository Messages { get; }
			INoterepositoryRepository NoteRepositorys { get; }
			IAspnetuserloginconfigurationrepositoryRepository AspnetuserloginconfigurationRepositorys { get; }
			IAspnetuserconfigurationrepositoryRepository AspnetuserconfigurationRepositorys { get; }
			IAspnetrolerepositoryRepository AspnetroleRepositorys { get; }
			IAspnetroleconfigurationrepositoryrepositoryRepository AspnetroleconfigurationrepositoryRepositorys { get; }
			INoteRepository Notes { get; }
			IAspnetroleRepository AspNetRoles { get; }
			IQuestionrepositoryrepositoryRepository QuestionrepositoryRepositorys { get; }
			IInternunitofworkrepositoryRepository InternunitofworkRepositorys { get; }
			IAspnetrolerepositoryrepositoryrepositoryRepository AspnetrolerepositoryrepositoryRepositorys { get; }
			IAnswerconfigurationrepositoryRepository AnswerconfigurationRepositorys { get; }
			IAnswerRepository Answers { get; }
			IQuestionoptionrepositoryRepository QuestionoptionRepositorys { get; }
			IMessageconfigurationrepositoryrepositoryRepository MessageconfigurationrepositoryRepositorys { get; }
			IInternportalcontextfactoryrepositoryrepositoryRepository InternportalcontextfactoryrepositoryRepositorys { get; }
			IAspnetuserrepositoryRepository AspnetuserRepositorys { get; }
			IAspnetroleconfigurationrepositoryrepositoryrepositoryRepository AspnetroleconfigurationrepositoryrepositoryRepositorys { get; }
			IQuestiontypeRepository QuestionTypes { get; }
			IAnswerconfigurationRepository AnswerConfigurations { get; }
			IUseruploadconfigurationrepositoryrepositoryRepository UseruploadconfigurationrepositoryRepositorys { get; }
			IInternportalcontextfactoryrepositoryrepositoryrepositoryRepository InternportalcontextfactoryrepositoryrepositoryRepositorys { get; }
			IAspnetuserclaimrepositoryrepositoryRepository AspnetuserclaimrepositoryRepositorys { get; }
			IQuestiontypeconfigurationRepository QuestionTypeConfigurations { get; }
			IApplicationstatuRepository ApplicationStatus { get; }
			IUseruploadrepositoryRepository UseruploadRepositorys { get; }
			IUseruploadconfigurationrepositoryRepository UseruploadconfigurationRepositorys { get; }
			IUserrepositoryrepositoryRepository UserrepositoryRepositorys { get; }
			IApplicationdbcontextrepositoryRepository ApplicationdbcontextRepositorys { get; }
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
			IAspnetuserloginrepositoryrepositoryrepositoryRepository AspnetuserloginrepositoryrepositoryRepositorys { get; }
			IAspnetuserclaimrepositoryRepository AspnetuserclaimRepositorys { get; }
			IUserRepository Users { get; }
			IUseruploadrepositoryrepositoryRepository UseruploadrepositoryRepositorys { get; }
			IMessagerepositoryrepositoryRepository MessagerepositoryRepositorys { get; }
			IAspnetuserloginrepositoryRepository AspnetuserloginRepositorys { get; }
			IAspnetuserclaimrepositoryrepositoryrepositoryRepository AspnetuserclaimrepositoryrepositoryRepositorys { get; }
			IAspnetuserclaimconfigurationrepositoryrepositoryRepository AspnetuserclaimconfigurationrepositoryRepositorys { get; }
			IApplicationuserrepositoryRepository ApplicationuserRepositorys { get; }
			IApplicationstaturepositoryrepositoryRepository ApplicationstaturepositoryRepositorys { get; }
			IAnswerconfigurationrepositoryrepositoryRepository AnswerconfigurationrepositoryRepositorys { get; }
			IMessageconfigurationRepository MessageConfigurations { get; }
			IApplicationconfigurationRepository ApplicationConfigurations { get; }
			IInternunitofworkrepositoryrepositoryRepository InternunitofworkrepositoryRepositorys { get; }
			IAnswerrepositoryrepositoryRepository AnswerrepositoryRepositorys { get; }
			IApplicationuserRepository ApplicationUsers { get; }
			IApplicationdbcontextRepository ApplicationDbContexts { get; }
			IAspnetroleconfigurationRepository AspNetRoleConfigurations { get; }
			IQuestiontypeconfigurationrepositoryrepositoryRepository QuestiontypeconfigurationrepositoryRepositorys { get; }
			IQuestionconfigurationrepositoryrepositoryRepository QuestionconfigurationrepositoryRepositorys { get; }
			IApplicationstaturepositoryRepository ApplicationstatuRepositorys { get; }
			IApplicationrepositoryRepository ApplicationRepositorys { get; }
			IApplicationconfigurationrepositoryRepository ApplicationconfigurationRepositorys { get; }
			IApplicationRepository Applications { get; }
			IApplicationconfigurationrepositoryrepositoryRepository ApplicationconfigurationrepositoryRepositorys { get; }
			IUserconfigurationrepositoryrepositoryRepository UserconfigurationrepositoryRepositorys { get; }
			IQuestionoptionrepositoryrepositoryRepository QuestionoptionrepositoryRepositorys { get; }
			IApplicationstatuconfigurationRepository ApplicationStatuConfigurations { get; }
			IPositionconfigurationRepository PositionConfigurations { get; }
			IPositionRepository Positions { get; }
			
	//Change this to the context type
	IInternPortalContext Context();
	void Complete();

	}
}
