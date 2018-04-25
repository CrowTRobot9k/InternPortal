namespace InternPortal.Data.Migrations
{
    using InternPortal.Data.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.AspNet.Identity;

    internal sealed class Configuration : DbMigrationsConfiguration<InternPortal.Data.Models.InternPortalContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(InternPortal.Data.Models.InternPortalContext context)
        {
            SeedRoles(context);

            SeedUsers(context);
        }

        private void SeedRoles(IInternPortalContext context)
        {
            var appContext = new ApplicationDbContext();

            var roleStore = new RoleStore<IdentityRole>(appContext);
            var roleManager = new RoleManager<IdentityRole>(roleStore);

            roleManager.Create(new IdentityRole { Name = "admin" });
            roleManager.Create(new IdentityRole { Name = "intern" });
        }

        private void SeedUsers(IInternPortalContext context)
        {
            var appContext = new ApplicationDbContext();
            var userStore = new UserStore<ApplicationUser>(appContext);
            var userManager = new UserManager<ApplicationUser>(userStore);

            var roleStore = new RoleStore<IdentityRole>(appContext);
            var roleManager = new RoleManager<IdentityRole>(roleStore);

            if (!context.AspNetUsers.Any(u => u.Email == "peteramathieu@gmail.com"))
            {
                var user = new ApplicationUser { UserName = "peteramathieu@gmail.com",Email= "peteramathieu@gmail.com" };

                userManager.Create(user, "p@ssw0rd");
                userManager.AddToRole(user.Id, "admin");
            }

            if (!context.AspNetUsers.Any(u => u.Email == "peter_mathieu@yahoo.com"))
            {
                var user = new ApplicationUser { UserName = "peter_mathieu@yahoo.com", Email = "peter_mathieu@yahoo.com" };

                userManager.Create(user, "p@ssw0rd");
                userManager.AddToRole(user.Id, "intern");
            }

        }
    }
}
