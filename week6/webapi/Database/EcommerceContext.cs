using System.Collections.Generic;

using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.Configuration;



namespace Database

{
   public class ECommerceContext : DbContext
    {
        public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options)         
        {         
        }
        
        public DbSet<Students> Product { get; set; }
        public DbSet<Persons> Manufacturer { get; set; }
    }
}