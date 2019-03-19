using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Database.Entities;


namespace Database

{
   public class ECommerceContext : DbContext
    {
        public ECommerceContext(DbContextOptions<ECommerceContext> options) : base(options)         
        {         
        }
        
        public DbSet<Services> Service { get; set; }
        public DbSet<Employees> Employee { get; set; }
        public DbSet<Projects> Project { get; set; }
    }
}