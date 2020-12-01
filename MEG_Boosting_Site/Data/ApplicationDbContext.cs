using System;
using System.Collections.Generic;
using System.Text;
using MEG_Boosting_Site.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MEG_Boosting_Site.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Product> Products { get; set; }
        
        public DbSet<CustomOrder> CustomOrders { get; set; }
        
        public DbSet<Order> Orders { get; set; }
    }
}
