using LayeredApp.Domain.Server.Core.Database.Entities;
using LayeredApp.Server.Core.Database.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Server.Core.Database
{
    public class LayeredAppDbContext : DbContext
    {
        public LayeredAppDbContext(DbContextOptions<LayeredAppDbContext> dbContextOptions) :
            base(dbContextOptions)
        {

        }

        public LayeredAppDbContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=LayeredApp;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            new ContactConfiguration(modelBuilder.Entity<Contact>());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Contact> ContactDbSet { get; set; }
    }
}
