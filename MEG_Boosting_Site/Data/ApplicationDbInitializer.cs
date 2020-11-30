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
            
            // Create an admin user
            var admin = new ApplicationUser
            {
                Nickname = "MEG_Admin",
                UserName = "admin@uia.no",
                Email = "admin@uia.no",
                EmailConfirmed = true
            };

            um.CreateAsync(admin, "Password1.").Wait();
            um.AddToRoleAsync(admin, "Admin");
            
            // Create 10 regular users and 10 reviews
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
                    Title = $"Title for review nr {i}",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing" +
                              " elit, sed do eiusmod tempor incididunt ut labore et" +
                              " dolore magna aliqua. Auctor neque vitae tempus quam" +
                              " pellentesque nec. Est placerat in egestas erat." +
                              " Massa tempor nec feugiat nisl pretium fusce id" +
                              " velit ut. Sit amet est placerat in egestas erat imperdiet." +
                              " Massa massa ultricies mi quis. Purus semper eget duis at" +
                              " tellus at urna condimentum. Gravida quis blandit turpis" +
                              " cursus in hac. Pellentesque sit amet porttitor eget dolor" +
                              " morbi non arcu risus.",
                    ApplicationUser = admin
                };

                db.Add(review);
            }

            for (int i = 0; i < 5; i++)
            {
                var topreview = new Review
                    {
                    Title = $"Title for review nr {i}",
                    Content = "Lorem ipsum dolor sit amet, consectetur adipiscing" +
                              " elit, sed do eiusmod tempor incididunt ut labore et" +
                              " dolore magna aliqua. Auctor neque vitae tempus quam" +
                              " pellentesque nec. Est placerat in egestas erat." +
                              " Massa tempor nec feugiat nisl pretium fusce id" +
                              " velit ut. Sit amet est placerat in egestas erat imperdiet." +
                              " Massa massa ultricies mi quis. Purus semper eget duis at" +
                              " tellus at urna condimentum. Gravida quis blandit turpis" +
                              " cursus in hac. Pellentesque sit amet porttitor eget dolor" +
                              " morbi non arcu risus.",
                    ApplicationUser = admin,
                    TopReview = true
                };

                db.Add(topreview);
            };


            // Make 10 Boosts of each service
            for (int i = 1; i <= 10; i++)
            {
                var WoWRetail = new Product
                {
                    Service = "WoWRetail",
                    Name = $"WoWRetailBoost nr { i }",
                    Details = "<ul>" +
                              "<li>" +
                              "You will get boosted hard   " +
                              "</li>" +
                              "<li>" +
                              "We will carry you all the way to the top   " +
                              "</li>" +
                              "<li>" +
                              "You will pay us grand dollaritos" +
                              "</li>" +
                              "<li>" +
                              "We will be able to deliver (the project) on time. (hopefully)" +
                              "</li>" +
                              "<li>" +
                              "This will be a very pleasant experience" +
                              "</li>" +
                              "<li>" +
                              "If you have any questions feel free to visit the F.A.Q site, or contact us by mail" +
                              "</li>" +
                              "</ul>",
                    Image = "~/images/wow-logo-navbar.png",
                    Price = 10 * i
                };
                db.Add(WoWRetail);

                var WoWClassic = new Product
                {
                    Service = "WoWClassic",
                    Name = $"WoWClassicBoost nr { i }",
                    Details = "<ul>" +
                              "<li>" +
                              "You will get boosted hard   " +
                              "</li>" +
                              "<li>" +
                              "We will carry you all the way to the top   " +
                              "</li>" +
                              "<li>" +
                              "You will pay us grand dollaritos" +
                              "</li>" +
                              "<li>" +
                              "We will be able to deliver (the project) on time. (hopefully)" +
                              "</li>" +
                              "<li>" +
                              "This will be a very pleasant experience" +
                              "</li>" +
                              "<li>" +
                              "If you have any questions feel free to visit the F.A.Q site, or contact us by mail" +
                              "</li>" +
                              "</ul>",
                    Image = "~/images/wow-logo-navbar.png",
                    Price = 10 * i
                };
                db.Add(WoWClassic);

                var CSGO = new Product
                {
                    Service = "CSGO",
                    Name = $"CSGOBoost nr { i }",
                    Details = $"Some very interesting details about boost nr { i }",
                    Image = $"cool-image-nr{ i }",
                    Price = 10 * i
                };
                db.Add(CSGO);

                var LoL = new Product
                {
                    Service = "LoL",
                    Name = $"LoLBoost nr { i }",
                    Details = $"Some very interesting details about boost nr { i }",
                    Image = $"cool-image-nr{ i }",
                    Price = 10 * i
                };
                db.Add(LoL);

                var Overwatch = new Product
                {
                    Service = "Overwatch",
                    Name = $"OverwatchBoost nr { i }",
                    Details = $"Some very interesting details about boost nr { i }",
                    Image = $"cool-image-nr{ i }",
                    Price = 10 * i
                };
                db.Add(Overwatch);

                var Rone = new Product
                {
                    Service = "R1",
                    Name = $"R1 Math Boost { i }",
                    Details = "<ul>" +
                              "<li>" +
                              "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                              "</li>" +
                              "<li>" +
                              "Curabitur ultricies mattis est et efficitur." +
                              "</li>" +
                              "<li>" +
                              "Sed eleifend convallis justo at maximus. Phasellus porta in ex et interdum." +
                              "</li>" +
                              "<li>" +
                              "Curabitur consectetur tempor dapibus. Vivamus blandit ac quam id scelerisque." +
                              "</li>" +
                              "<li>" +
                              "Maecenas libero dui, eleifend rutrum nisl finibus, vulputate sagittis leo. Cras porta magna " +
                              "eu sapien rhoncus mollis sed a felis. Vivamus ut malesuada enim. Proin ac libero facilisis, " +
                              "viverra felis eget, tempus erat." +
                              "</li>" +
                              "<li>" +
                              "Morbi finibus faucibus lectus nec ullamcorper." +
                              "</li>" +
                              "</ul>",
                    Image = "~/images/School/ROne_Temp.png",
                    Price = 10 * i
                };
                db.Add(Rone);

                var Rtwo = new Product
                {
                    Service = "R2",
                    Name = $"R2 Math Boost { i }",
                    Details = "<ul>" +
                              "<li>" +
                              "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                              "</li>" +
                              "<li>" +
                              "Curabitur ultricies mattis est et efficitur." +
                              "</li>" +
                              "<li>" +
                              "Sed eleifend convallis justo at maximus. Phasellus porta in ex et interdum." +
                              "</li>" +
                              "<li>" +
                              "Curabitur consectetur tempor dapibus. Vivamus blandit ac quam id scelerisque." +
                              "</li>" +
                              "<li>" +
                              "Maecenas libero dui, eleifend rutrum nisl finibus, vulputate sagittis leo. Cras porta magna " +
                              "eu sapien rhoncus mollis sed a felis. Vivamus ut malesuada enim. Proin ac libero facilisis, " +
                              "viverra felis eget, tempus erat." +
                              "</li>" +
                              "<li>" +
                              "Morbi finibus faucibus lectus nec ullamcorper." +
                              "</li>" +
                              "</ul>",
                    Image = "~/images/School/RTwo_Temp.png",
                    Price = 10 * i
                };
                db.Add(Rtwo);

                var Mone = new Product
                {
                    Service = "M1",
                    Name = $"M1 Math Boost { i }",
                    Details = "<ul>" +
                              "<li>" +
                              "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                              "</li>" +
                              "<li>" +
                              "Curabitur ultricies mattis est et efficitur." +
                              "</li>" +
                              "<li>" +
                              "Sed eleifend convallis justo at maximus. Phasellus porta in ex et interdum." +
                              "</li>" +
                              "<li>" +
                              "Curabitur consectetur tempor dapibus. Vivamus blandit ac quam id scelerisque." +
                              "</li>" +
                              "<li>" +
                              "Maecenas libero dui, eleifend rutrum nisl finibus, vulputate sagittis leo. Cras porta magna " +
                              "eu sapien rhoncus mollis sed a felis. Vivamus ut malesuada enim. Proin ac libero facilisis, " +
                              "viverra felis eget, tempus erat." +
                              "</li>" +
                              "<li>" +
                              "Morbi finibus faucibus lectus nec ullamcorper." +
                              "</li>" +
                              "</ul>",
                    Image = "~/images/School/MOne_Temp.png",
                    Price = 10 * i
                };
                db.Add(Mone);

                var Mtwo = new Product
                {
                    Service = "M2",
                    Name = $"M2 Math Boost { i }",
                    Details = "<ul>" +
                              "<li>" +
                              "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                              "</li>" +
                              "<li>" +
                              "Curabitur ultricies mattis est et efficitur." +
                              "</li>" +
                              "<li>" +
                              "Sed eleifend convallis justo at maximus. Phasellus porta in ex et interdum." +
                              "</li>" +
                              "<li>" +
                              "Curabitur consectetur tempor dapibus. Vivamus blandit ac quam id scelerisque." +
                              "</li>" +
                              "<li>" +
                              "Maecenas libero dui, eleifend rutrum nisl finibus, vulputate sagittis leo. Cras porta magna " +
                              "eu sapien rhoncus mollis sed a felis. Vivamus ut malesuada enim. Proin ac libero facilisis, " +
                              "viverra felis eget, tempus erat." +
                              "</li>" +
                              "<li>" +
                              "Morbi finibus faucibus lectus nec ullamcorper." +
                              "</li>" +
                              "</ul>",
                    Image = "~/images/School/MTwo_Temp.png",
                    Price = 10 * i
                };
                db.Add(Mtwo);

                var Mthree = new Product
                {
                    Service = "M3",
                    Name = $"M3 Math Boost { i }",
                    Details = "<ul>" +
                              "<li>" +
                              "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                              "</li>" +
                              "<li>" +
                              "Curabitur ultricies mattis est et efficitur." +
                              "</li>" +
                              "<li>" +
                              "Sed eleifend convallis justo at maximus. Phasellus porta in ex et interdum." +
                              "</li>" +
                              "<li>" +
                              "Curabitur consectetur tempor dapibus. Vivamus blandit ac quam id scelerisque." +
                              "</li>" +
                              "<li>" +
                              "Maecenas libero dui, eleifend rutrum nisl finibus, vulputate sagittis leo. Cras porta magna " +
                              "eu sapien rhoncus mollis sed a felis. Vivamus ut malesuada enim. Proin ac libero facilisis, " +
                              "viverra felis eget, tempus erat." +
                              "</li>" +
                              "<li>" +
                              "Morbi finibus faucibus lectus nec ullamcorper." +
                              "</li>" +
                              "</ul>",
                    Image = "~/images/School/MThree_Temp.png",
                    Price = 10 * i
                };
                db.Add(Mthree);

                var DMone = new Product
                {
                    Service = "DM1",
                    Name = $"DM1 Math Boost { i }",
                    Details = "<ul>" +
                              "<li>" +
                              "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                              "</li>" +
                              "<li>" +
                              "Curabitur ultricies mattis est et efficitur." +
                              "</li>" +
                              "<li>" +
                              "Sed eleifend convallis justo at maximus. Phasellus porta in ex et interdum." +
                              "</li>" +
                              "<li>" +
                              "Curabitur consectetur tempor dapibus. Vivamus blandit ac quam id scelerisque." +
                              "</li>" +
                              "<li>" +
                              "Maecenas libero dui, eleifend rutrum nisl finibus, vulputate sagittis leo. Cras porta magna " +
                              "eu sapien rhoncus mollis sed a felis. Vivamus ut malesuada enim. Proin ac libero facilisis, " +
                              "viverra felis eget, tempus erat." +
                              "</li>" +
                              "<li>" +
                              "Morbi finibus faucibus lectus nec ullamcorper." +
                              "</li>" +
                              "</ul>",
                    Image = "~/images/School/DMOne_Temp.png",
                    Price = 10 * i
                };
                db.Add(DMone);

                var DMtwo = new Product
                {
                    Service = "DM2",
                    Name = $"DM2 Math Boost { i }",
                    Details = "<ul>" +
                              "<li>" +
                              "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                              "</li>" +
                              "<li>" +
                              "Curabitur ultricies mattis est et efficitur." +
                              "</li>" +
                              "<li>" +
                              "Sed eleifend convallis justo at maximus. Phasellus porta in ex et interdum." +
                              "</li>" +
                              "<li>" +
                              "Curabitur consectetur tempor dapibus. Vivamus blandit ac quam id scelerisque." +
                              "</li>" +
                              "<li>" +
                              "Maecenas libero dui, eleifend rutrum nisl finibus, vulputate sagittis leo. Cras porta magna " +
                              "eu sapien rhoncus mollis sed a felis. Vivamus ut malesuada enim. Proin ac libero facilisis, " +
                              "viverra felis eget, tempus erat." +
                              "</li>" +
                              "<li>" +
                              "Morbi finibus faucibus lectus nec ullamcorper." +
                              "</li>" +
                              "</ul>",
                    Image = "~/images/School/DMTwo_Temp.png",
                    Price = 10 * i
                };
                db.Add(DMtwo);
                
            }

            for (int i = 1; i <= 10; i++)
            {
                var CustomTest = new CustomOrder
                {
                    Name = $"Test bruker nr { i }",
                    Details = $"Test custom order { i }",
                    ApplicationUser = admin
                };
                
                db.Add(CustomTest);
            }
            
            // Create bestsellers for the homeview
            
            var BestSellerWoWC = new Product
            {
                Service = "WoWClassic",
                Name = "Classic BestSeller",
                Details = "<ul>" +
                          "<li>" +
                          "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                          "</li>" +
                          "<li>" +
                          "Curabitur ultricies mattis est et efficitur." +
                          "</li>" +
                          "<li>" +
                          "Sed eleifend convallis justo at maximus. Phasellus porta in ex et interdum." +
                          "</li>" +
                          "<li>" +
                          "Curabitur consectetur tempor dapibus. Vivamus blandit ac quam id scelerisque." +
                          "</li>" +
                          "<li>" +
                          "Maecenas libero dui, eleifend rutrum nisl finibus, vulputate sagittis leo. Cras porta magna " +
                          "eu sapien rhoncus mollis sed a felis. Vivamus ut malesuada enim. Proin ac libero facilisis, " +
                          "viverra felis eget, tempus erat." +
                          "</li>" +
                          "<li>" +
                          "Morbi finibus faucibus lectus nec ullamcorper." +
                          "</li>" +
                          "</ul>",
                Image = "~/images/wow-logo-navbar.png",
                Price = 100,
                BestSeller = true
            };

            db.Add(BestSellerWoWC);
            
            var BestSellerWoWR = new Product
            {
                Service = "WoWRetail",
                Name = "Retail BestSeller",
                Details = "<ul>" +
                          "<li>" +
                          "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                          "</li>" +
                          "<li>" +
                          "Curabitur ultricies mattis est et efficitur." +
                          "</li>" +
                          "<li>" +
                          "Sed eleifend convallis justo at maximus. Phasellus porta in ex et interdum." +
                          "</li>" +
                          "<li>" +
                          "Curabitur consectetur tempor dapibus. Vivamus blandit ac quam id scelerisque." +
                          "</li>" +
                          "<li>" +
                          "Maecenas libero dui, eleifend rutrum nisl finibus, vulputate sagittis leo. Cras porta magna " +
                          "eu sapien rhoncus mollis sed a felis. Vivamus ut malesuada enim. Proin ac libero facilisis, " +
                          "viverra felis eget, tempus erat." +
                          "</li>" +
                          "<li>" +
                          "Morbi finibus faucibus lectus nec ullamcorper." +
                          "</li>" +
                          "</ul>",
                Image = "~/images/wow-logo-navbar.png",
                Price = 100,
                BestSeller = true
            };

            db.Add(BestSellerWoWR);
            
            var BestSellerCSGO = new Product
            {
                Service = "CSGO",
                Name = "CSGO BestSeller",
                Details = "<ul>" +
                          "<li>" +
                          "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                          "</li>" +
                          "<li>" +
                          "Curabitur ultricies mattis est et efficitur." +
                          "</li>" +
                          "<li>" +
                          "Sed eleifend convallis justo at maximus. Phasellus porta in ex et interdum." +
                          "</li>" +
                          "<li>" +
                          "Curabitur consectetur tempor dapibus. Vivamus blandit ac quam id scelerisque." +
                          "</li>" +
                          "<li>" +
                          "Maecenas libero dui, eleifend rutrum nisl finibus, vulputate sagittis leo. Cras porta magna " +
                          "eu sapien rhoncus mollis sed a felis. Vivamus ut malesuada enim. Proin ac libero facilisis, " +
                          "viverra felis eget, tempus erat." +
                          "</li>" +
                          "<li>" +
                          "Morbi finibus faucibus lectus nec ullamcorper." +
                          "</li>" +
                          "</ul>",
                Image = "~/images/wow-logo-navbar.png",
                Price = 100,
                BestSeller = true
            };

            db.Add(BestSellerCSGO);
            
            var BestSellerOW = new Product
            {
                Service = "Overwatch",
                Name = "Overwatch BestSeller",
                Details = "<ul>" +
                          "<li>" +
                          "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                          "</li>" +
                          "<li>" +
                          "Curabitur ultricies mattis est et efficitur." +
                          "</li>" +
                          "<li>" +
                          "Sed eleifend convallis justo at maximus. Phasellus porta in ex et interdum." +
                          "</li>" +
                          "<li>" +
                          "Curabitur consectetur tempor dapibus. Vivamus blandit ac quam id scelerisque." +
                          "</li>" +
                          "<li>" +
                          "Maecenas libero dui, eleifend rutrum nisl finibus, vulputate sagittis leo. Cras porta magna " +
                          "eu sapien rhoncus mollis sed a felis. Vivamus ut malesuada enim. Proin ac libero facilisis, " +
                          "viverra felis eget, tempus erat." +
                          "</li>" +
                          "<li>" +
                          "Morbi finibus faucibus lectus nec ullamcorper." +
                          "</li>" +
                          "</ul>",
                Image = "~/images/wow-logo-navbar.png",
                Price = 100,
                BestSeller = true
            };

            db.Add(BestSellerOW);
            
            var BestSellerLOL = new Product
            {
                Service = "LoL",
                Name = "LoL BestSeller",
                Details = "<ul>" +
                          "<li>" +
                          "Lorem ipsum dolor sit amet, consectetur adipiscing elit." +
                          "</li>" +
                          "<li>" +
                          "Curabitur ultricies mattis est et efficitur." +
                          "</li>" +
                          "<li>" +
                          "Sed eleifend convallis justo at maximus. Phasellus porta in ex et interdum." +
                          "</li>" +
                          "<li>" +
                          "Curabitur consectetur tempor dapibus. Vivamus blandit ac quam id scelerisque." +
                          "</li>" +
                          "<li>" +
                          "Maecenas libero dui, eleifend rutrum nisl finibus, vulputate sagittis leo. Cras porta magna " +
                          "eu sapien rhoncus mollis sed a felis. Vivamus ut malesuada enim. Proin ac libero facilisis, " +
                          "viverra felis eget, tempus erat." +
                          "</li>" +
                          "<li>" +
                          "Morbi finibus faucibus lectus nec ullamcorper." +
                          "</li>" +
                          "</ul>",
                Image = "~/images/wow-logo-navbar.png",
                Price = 100,
                BestSeller = true
            };

            db.Add(BestSellerLOL);
            
            db.SaveChanges();
        }
    }
}