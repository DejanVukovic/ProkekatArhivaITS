namespace ITSProject.Migrations
{
	using ITSProject.Models;
	using Microsoft.AspNet.Identity;
	using Microsoft.AspNet.Identity.EntityFramework;
	using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ITSProject.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "ITSProject.Models.ApplicationDbContext";
        }

        protected override void Seed(ITSProject.Models.ApplicationDbContext context)
        {
           	var userStore = new UserStore<ApplicationUser>(context);
			var userManager = new UserManager<ApplicationUser>(userStore);
            //pravljenje rola i dodeljivanje role admin i employee
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            var role = new IdentityRole();
            role.Name = "Admin";
            roleManager.Create(role);

            if (!context.Users.Any(t => t.UserName == "Admin"))
            {
                var User = new ApplicationUser { UserName = "Admin", Email = "Admin@gmail.com" };
                userManager.Create(User, "passW0rd?");

                userManager.AddToRole(User.Id, "Admin");
                context.SaveChanges();
            }

            var role1 = new IdentityRole();
            role1.Name = "Employee";
            roleManager.Create(role1);

            if (!context.Users.Any(t => t.UserName == "Employee"))
            {
                var User = new ApplicationUser { UserName = "Employee", Email = "Employee@gmail.com" };
                userManager.Create(User, "Sifra123?");

                userManager.AddToRole(User.Id, "Employee");
                context.SaveChanges();
            }

            var role2 = new IdentityRole();
            role2.Name = "Guest";
            roleManager.Create(role2);

            context.SaveChanges();
                
        }
    }
}
