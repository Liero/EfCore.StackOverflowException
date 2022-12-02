
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using EfCoreApp.Models;
using EfCoreApp.Models.Custom;
using System;

#nullable disable


namespace EfCoreApp
{
    public partial class ManufactureDbContext : DbContext
    {
        public ManufactureDbContext()
        {
        }

        public ManufactureDbContext(DbContextOptions<ManufactureDbContext> options)
            : base(options)
        {
        }


        public virtual DbSet<ČíselníkMateriál> ČíselníkMateriál { get; set; }

      
        public virtual DbSet<ČíselníkVýrobky> ČíselníkVýrobky { get; set; }
        public virtual DbSet<ČíselníkVýrobkyMateriál> ČíselníkVýrobkyMateriál { get; set; }
   
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(this.GetType().Assembly);
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                   .UseSqlServer(@"Data Source=(LocalDb)\MSSQLLocalDB;Database=AllTogetherNow")
                   .LogTo(Console.WriteLine, LogLevel.Information)
                   .EnableSensitiveDataLogging();
            }
        }
    }
}
