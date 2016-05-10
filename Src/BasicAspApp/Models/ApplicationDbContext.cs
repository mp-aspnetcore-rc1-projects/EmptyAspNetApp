


using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using System;

namespace BasicAspApp.Models
{
    public class ApplicationDbContext : DbContext
    {
        // public ApplicationDbContext(DbContextOptions options):base(options){}
        public DbSet<Snippet> Snippets { get; set; }
        public DbSet<ComputerLanguage> ComputerLanguages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var cl = modelBuilder.Entity<ComputerLanguage>();
            cl.Property(b => b.CreationDate)
            .HasDefaultValue(DateTime.Now);
            cl.Property(b => b.UpdateDate)
            .HasDefaultValue(DateTime.Now);

            var snippetEntity = modelBuilder.Entity<Snippet>();
            snippetEntity.Property(b => b.CreationDate)
            .HasDefaultValue(DateTime.Now);
            snippetEntity.Property(b => b.UpateDate)
            .HasDefaultValue(DateTime.Now);
        }
    }

}