using MEG_Boosting_Site.Models;
using Microsoft.AspNetCore.Identity;

namespace MEG_Boosting_Site.Data
{
    public class ApplicationDbInitializer
    {
        public static void Initialize(ApplicationDbContext db, UserManager<ApplicationUser> um,
            RoleManager<IdentityRole> rm)
        {
            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            
            var adminRole = new IdentityRole("Admin");
            rm.CreateAsync(adminRole).Wait();

            var admin = new ApplicationUser
            {
                Nickname = "MEG_Admin",
                UserName = "admin@uia.no",
                Email = "admin@uia.no",
                EmailConfirmed = true
            };

            um.CreateAsync(admin, "Password1.").Wait();
            um.AddToRoleAsync(admin, "Admin");

            for (int i = 1; i <= 10; i++)
            {
                var user = new ApplicationUser
                {
                    Nickname = $"nick{ i }",
                    UserName = $"user{ i }@uia.no",
                    Email = $"user{ i }@uia.no",
                    EmailConfirmed = true
                };

                um.CreateAsync(user, "Password1.").Wait();
                
                var review = new Review
                {
                    Title = $"Title {i}",
                    Content = $"ReviewContent {i}",
                    ApplicationUser = admin
                };

                db.Add(review);
            }

            db.SaveChanges();
        }
    }
}