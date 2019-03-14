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
        
        public DbSet<Students> Student { get; set; }
        public DbSet<Persons> Person { get; set; }
    }
}