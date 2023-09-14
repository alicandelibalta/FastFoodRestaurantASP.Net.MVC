using Hamburgerci.EntityLayer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Hamburgerci.DataAccessLayer
{
    public class Context : IdentityDbContext<AppUser, AppRole, int>
    {
        public Context()
        {
            
        }

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-Q6HN4J3;Database=HamburgerciDB;Trusted_Connection=True; encrypt=false").UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking); ;
            base.OnConfiguring(optionsBuilder);
        }

        //OnModelCreatingSeedData

        public DbSet<Beverage> Beverages { get; set; }
        public DbSet<Burger> Burgers { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Fry> Fries { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Sauce> Sauces { get; set; }

    }
}
