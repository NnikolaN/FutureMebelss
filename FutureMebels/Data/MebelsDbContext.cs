using FutureMebels.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;


namespace FutureMebels.Data
{
    public class MebelsDbContext : IdentityDbContext<Customer>
    {
        public MebelsDbContext(DbContextOptions<MebelsDbContext> options)
             : base(options)
        {
        }
        public DbSet<Articul> Articuls { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Type> Types { get; set; }

       
    }

}