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
	
			public IAspnetuserloginconfigurationRepository AspNetUserLoginConfigurations => new AspnetuserloginconfigurationRepository(_context);

			public IAspnetuserclaimconfigurationRepository AspNetUserClaimConfigurations => new AspnetuserclaimconfigurationRepository(_context);

			public IAspnetuserconfigurationRepository AspNetUserConfigurations => new AspnetuserconfigurationRepository(_context);

			public IAspnetroleconfigurationRepository AspNetRoleConfigurations => new AspnetroleconfigurationRepository(_context);

			public IAspnetuserloginRepository AspNetUserLogins => new AspnetuserloginRepository(_context);

			public IAspnetuserclaimRepository AspNetUserClaims => new AspnetuserclaimRepository(_context);

			public IAspnetuserRepository AspNetUsers => new AspnetuserRepository(_context);

			public IAspnetroleRepository AspNetRoles => new AspnetroleRepository(_context);

			public IInternportalcontextfactoryRepository InternPortalContextFactorys => new InternportalcontextfactoryRepository(_context);

			public IAspnetuserloginconfigurationrepositoryRepository AspnetuserloginconfigurationRepositorys => new AspnetuserloginconfigurationrepositoryRepository(_context);

			public IAspnetuserclaimconfigurationrepositoryRepository AspnetuserclaimconfigurationRepositorys => new AspnetuserclaimconfigurationrepositoryRepository(_context);

			public IAspnetuserconfigurationrepositoryRepository AspnetuserconfigurationRepositorys => new AspnetuserconfigurationrepositoryRepository(_context);

			public IAspnetroleconfigurationrepositoryRepository AspnetroleconfigurationRepositorys => new AspnetroleconfigurationrepositoryRepository(_context);

			public IAspnetuserloginrepositoryRepository AspnetuserloginRepositorys => new AspnetuserloginrepositoryRepository(_context);

			public IAspnetuserclaimrepositoryRepository AspnetuserclaimRepositorys => new AspnetuserclaimrepositoryRepository(_context);

			public IAspnetuserrepositoryRepository AspnetuserRepositorys => new AspnetuserrepositoryRepository(_context);

			public IAspnetrolerepositoryRepository AspnetroleRepositorys => new AspnetrolerepositoryRepository(_context);

			public IInternportalcontextfactoryrepositoryRepository InternportalcontextfactoryRepositorys => new InternportalcontextfactoryrepositoryRepository(_context);

			public IInternunitofworkRepository InternUnitOfWorks => new InternunitofworkRepository(_context);

			public IUseruploadconfigurationRepository UserUploadConfigurations => new UseruploadconfigurationRepository(_context);

			public IUserconfigurationRepository UserConfigurations => new UserconfigurationRepository(_context);

			public IQuestiontypeconfigurationRepository QuestionTypeConfigurations => new QuestiontypeconfigurationRepository(_context);

			public IQuestionoptionconfigurationRepository QuestionOptionConfigurations => new QuestionoptionconfigurationRepository(_context);

			public IQuestionconfigurationRepository QuestionConfigurations => new QuestionconfigurationRepository(_context);

			public IMessageconfigurationRepository MessageConfigurations => new MessageconfigurationRepository(_context);

			public IApplicationstatuconfigurationRepository ApplicationStatuConfigurations => new ApplicationstatuconfigurationRepository(_context);

			public IApplicationconfigurationRepository ApplicationConfigurations => new ApplicationconfigurationRepository(_context);

			public IAnswerconfigurationRepository AnswerConfigurations => new AnswerconfigurationRepository(_context);

			public IUseruploadRepository UserUploads => new UseruploadRepository(_context);

			public IUserRepository Users => new UserRepository(_context);

			public IQuestiontypeRepository QuestionTypes => new QuestiontypeRepository(_context);

			public IQuestionoptionRepository QuestionOptions => new QuestionoptionRepository(_context);

			public IQuestionRepository Questions => new QuestionRepository(_context);

			public IMessageRepository Messages => new MessageRepository(_context);

			public IApplicationstatuRepository ApplicationStatus => new ApplicationstatuRepository(_context);

			public IApplicationRepository Applications => new ApplicationRepository(_context);

			public IAnswerRepository Answers => new AnswerRepository(_context);

		
		public IInternContext Context()
		{
			return _context;
		}
	
		public void Complete()
		{
			_context.SaveChanges();
		}

	}
}
