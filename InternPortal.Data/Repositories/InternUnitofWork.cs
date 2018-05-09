using InternPortal.Data;
using InternPortal.Data.Models;

namespace InternPortal.Data.Models
{
	public class InternUnitOfWork : IInternUnitOfWork
	{
		private InternPortalContext _context;

		//public UnitOfWork(InternPortalContext context)
		//{
		   // _context = context;
		//}

		//Delete this default constructor if using an IoC container
		public InternUnitOfWork()
		{
			_context = new InternPortalContext();
		}
	
			public IAspnetuserloginrepositoryrepositoryRepository AspnetuserloginrepositoryRepositorys => new AspnetuserloginrepositoryrepositoryRepository(_context);

			public IQuestionoptionconfigurationRepository QuestionOptionConfigurations => new QuestionoptionconfigurationRepository(_context);

			public IAspnetuserclaimconfigurationRepository AspNetUserClaimConfigurations => new AspnetuserclaimconfigurationRepository(_context);

			public IAspnetuserRepository AspNetUsers => new AspnetuserRepository(_context);

			public IQuestiontyperepositoryRepository QuestiontypeRepositorys => new QuestiontyperepositoryRepository(_context);

			public IAspnetuserrepositoryrepositoryRepository AspnetuserrepositoryRepositorys => new AspnetuserrepositoryrepositoryRepository(_context);

			public IUseruploadconfigurationRepository UserUploadConfigurations => new UseruploadconfigurationRepository(_context);

			public IQuestionconfigurationRepository QuestionConfigurations => new QuestionconfigurationRepository(_context);

			public IAspnetuserloginRepository AspNetUserLogins => new AspnetuserloginRepository(_context);

			public IAspnetuserconfigurationRepository AspNetUserConfigurations => new AspnetuserconfigurationRepository(_context);

			public IUserrepositoryRepository UserRepositorys => new UserrepositoryRepository(_context);

			public IQuestionrepositoryRepository QuestionRepositorys => new QuestionrepositoryRepository(_context);

			public IMessageconfigurationrepositoryRepository MessageconfigurationRepositorys => new MessageconfigurationrepositoryRepository(_context);

			public IAspnetuserloginconfigurationRepository AspNetUserLoginConfigurations => new AspnetuserloginconfigurationRepository(_context);

			public IAspnetuserclaimRepository AspNetUserClaims => new AspnetuserclaimRepository(_context);

			public IInternportalcontextfactoryrepositoryRepository InternportalcontextfactoryRepositorys => new InternportalcontextfactoryrepositoryRepository(_context);

			public IAspnetuserclaimconfigurationrepositoryRepository AspnetuserclaimconfigurationRepositorys => new AspnetuserclaimconfigurationrepositoryRepository(_context);

			public IQuestionoptionconfigurationrepositoryRepository QuestionoptionconfigurationRepositorys => new QuestionoptionconfigurationrepositoryRepository(_context);

			public IQuestionconfigurationrepositoryRepository QuestionconfigurationRepositorys => new QuestionconfigurationrepositoryRepository(_context);

			public IAnswerrepositoryRepository AnswerRepositorys => new AnswerrepositoryRepository(_context);

			public IUseruploadRepository UserUploads => new UseruploadRepository(_context);

			public IMessageRepository Messages => new MessageRepository(_context);

			public IAspnetuserloginconfigurationrepositoryRepository AspnetuserloginconfigurationRepositorys => new AspnetuserloginconfigurationrepositoryRepository(_context);

			public IAspnetuserconfigurationrepositoryRepository AspnetuserconfigurationRepositorys => new AspnetuserconfigurationrepositoryRepository(_context);

			public IAspnetrolerepositoryRepository AspnetroleRepositorys => new AspnetrolerepositoryRepository(_context);

			public IAspnetroleconfigurationrepositoryrepositoryRepository AspnetroleconfigurationrepositoryRepositorys => new AspnetroleconfigurationrepositoryrepositoryRepository(_context);

			public IAspnetroleRepository AspNetRoles => new AspnetroleRepository(_context);

			public IInternunitofworkrepositoryRepository InternunitofworkRepositorys => new InternunitofworkrepositoryRepository(_context);

			public IAnswerconfigurationrepositoryRepository AnswerconfigurationRepositorys => new AnswerconfigurationrepositoryRepository(_context);

			public IAnswerRepository Answers => new AnswerRepository(_context);

			public IQuestionoptionrepositoryRepository QuestionoptionRepositorys => new QuestionoptionrepositoryRepository(_context);

			public IInternportalcontextfactoryrepositoryrepositoryRepository InternportalcontextfactoryrepositoryRepositorys => new InternportalcontextfactoryrepositoryrepositoryRepository(_context);

			public IAspnetuserrepositoryRepository AspnetuserRepositorys => new AspnetuserrepositoryRepository(_context);

			public IQuestiontypeRepository QuestionTypes => new QuestiontypeRepository(_context);

			public IAnswerconfigurationRepository AnswerConfigurations => new AnswerconfigurationRepository(_context);

			public IAspnetuserclaimrepositoryrepositoryRepository AspnetuserclaimrepositoryRepositorys => new AspnetuserclaimrepositoryrepositoryRepository(_context);

			public IQuestiontypeconfigurationRepository QuestionTypeConfigurations => new QuestiontypeconfigurationRepository(_context);

			public IApplicationstatuRepository ApplicationStatus => new ApplicationstatuRepository(_context);

			public IUseruploadrepositoryRepository UseruploadRepositorys => new UseruploadrepositoryRepository(_context);

			public IUseruploadconfigurationrepositoryRepository UseruploadconfigurationRepositorys => new UseruploadconfigurationrepositoryRepository(_context);

			public IQuestionoptionRepository QuestionOptions => new QuestionoptionRepository(_context);

			public IQuestionRepository Questions => new QuestionRepository(_context);

			public IInternportalcontextfactoryRepository InternPortalContextFactorys => new InternportalcontextfactoryRepository(_context);

			public IUserconfigurationrepositoryRepository UserconfigurationRepositorys => new UserconfigurationrepositoryRepository(_context);

			public IQuestiontypeconfigurationrepositoryRepository QuestiontypeconfigurationRepositorys => new QuestiontypeconfigurationrepositoryRepository(_context);

			public IInternunitofworkRepository InternUnitOfWorks => new InternunitofworkRepository(_context);

			public IAspnetuserloginconfigurationrepositoryrepositoryRepository AspnetuserloginconfigurationrepositoryRepositorys => new AspnetuserloginconfigurationrepositoryrepositoryRepository(_context);

			public IAspnetuserconfigurationrepositoryrepositoryRepository AspnetuserconfigurationrepositoryRepositorys => new AspnetuserconfigurationrepositoryrepositoryRepository(_context);

			public IAspnetrolerepositoryrepositoryRepository AspnetrolerepositoryRepositorys => new AspnetrolerepositoryrepositoryRepository(_context);

			public IAspnetroleconfigurationrepositoryRepository AspnetroleconfigurationRepositorys => new AspnetroleconfigurationrepositoryRepository(_context);

			public IApplicationstatuconfigurationrepositoryRepository ApplicationstatuconfigurationRepositorys => new ApplicationstatuconfigurationrepositoryRepository(_context);

			public IUserconfigurationRepository UserConfigurations => new UserconfigurationRepository(_context);

			public IMessagerepositoryRepository MessageRepositorys => new MessagerepositoryRepository(_context);

			public IAspnetuserclaimrepositoryRepository AspnetuserclaimRepositorys => new AspnetuserclaimrepositoryRepository(_context);

			public IUserRepository Users => new UserRepository(_context);

			public IAspnetuserloginrepositoryRepository AspnetuserloginRepositorys => new AspnetuserloginrepositoryRepository(_context);

			public IAspnetuserclaimconfigurationrepositoryrepositoryRepository AspnetuserclaimconfigurationrepositoryRepositorys => new AspnetuserclaimconfigurationrepositoryrepositoryRepository(_context);

			public IMessageconfigurationRepository MessageConfigurations => new MessageconfigurationRepository(_context);

			public IApplicationconfigurationRepository ApplicationConfigurations => new ApplicationconfigurationRepository(_context);

			public IApplicationuserRepository ApplicationUsers => new ApplicationuserRepository(_context);

			public IApplicationdbcontextRepository ApplicationDbContexts => new ApplicationdbcontextRepository(_context);

			public IAspnetroleconfigurationRepository AspNetRoleConfigurations => new AspnetroleconfigurationRepository(_context);

			public IApplicationstaturepositoryRepository ApplicationstatuRepositorys => new ApplicationstaturepositoryRepository(_context);

			public IApplicationrepositoryRepository ApplicationRepositorys => new ApplicationrepositoryRepository(_context);

			public IApplicationconfigurationrepositoryRepository ApplicationconfigurationRepositorys => new ApplicationconfigurationrepositoryRepository(_context);

			public IApplicationRepository Applications => new ApplicationRepository(_context);

			public IApplicationstatuconfigurationRepository ApplicationStatuConfigurations => new ApplicationstatuconfigurationRepository(_context);

			public INoteconfigurationRepository NoteConfigurations => new NoteconfigurationRepository(_context);

			public INoteRepository Notes => new NoteRepository(_context);

		
		public IInternPortalContext Context()
		{
			return _context;
		}
	
		public void Complete()
		{
			_context.SaveChanges();
		}

	}
}
