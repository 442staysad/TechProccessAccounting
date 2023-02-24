using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using MySql.Data;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using System;
using TechProccessAccounting.Core.Entities;
using System.Configuration;

namespace TechProccessAccounting.Infrastructure.Data
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("C:\\Users\\kerri\\Desktop\\par\\coursework\\TechProccessAccounting\\appsettings.json")
                .Build();
            var connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>()
                .UseMySql(connectionString,
                    ServerVersion.AutoDetect(connectionString) // Auto-detect server version
                );

            return new AppDbContext(optionsBuilder.Options);
        }
    }
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Material> Materials { get; set; }
        public DbSet<ProductAssembly> ProductAssemblies { get; set; }
        public DbSet<ProductDetail> ProductDetails { get; set; }
        public DbSet<ProductionLine> ProductionLines { get; set; }
        public DbSet<ProductionLog> ProductionLogs { get; set; }
        public DbSet<ProductionOperation> ProductionOperations { get; set; }
        public DbSet<ProductionOperationLog> ProductionOperationLogs { get; set; }
        public DbSet<Shift> Shifts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Связь между таблицами ProductionLog и ProductAssembly
            modelBuilder.Entity<ProductionLog>()
                .HasOne(p => p.ProductAssembly)
                .WithMany()
                .HasForeignKey(p => p.ProductAssemblyID)
                .OnDelete(DeleteBehavior.Cascade);

            // Связь между таблицами ProductionLog и Employee
            modelBuilder.Entity<ProductionLog>()
                .HasOne(p => p.Employee)
                .WithMany()
                .HasForeignKey(p => p.EmployeeID)
                .OnDelete(DeleteBehavior.Cascade);

            // Связь между таблицами ProductionOperationLog и ProductDetail
            modelBuilder.Entity<ProductionOperationLog>()
                .HasOne(p => p.ProductDetail)
                .WithMany()
                .HasForeignKey(p => p.ProductDetailID)
                .OnDelete(DeleteBehavior.Cascade);

            // Связь между таблицами ProductionOperationLog и ProductAssembly
            modelBuilder.Entity<ProductionOperationLog>()
                .HasOne(p => p.ProductAssembly)
                .WithMany()
                .HasForeignKey(p => p.ProductAssemblyID)
                .OnDelete(DeleteBehavior.Cascade);

            // Связь между таблицами ProductionOperationLog и ProductionOperation
            modelBuilder.Entity<ProductionOperationLog>()
                .HasOne(p => p.ProductionOperation)
                .WithMany()
                .HasForeignKey(p => p.ProductionOperationID)
                .OnDelete(DeleteBehavior.Cascade);

            // Связь между таблицами ProductionOperationLog и ProductionLine
            modelBuilder.Entity<ProductionOperationLog>()
                .HasOne(p => p.ProductionLine)
                .WithMany()
                .HasForeignKey(p => p.ProductionLineID)
                .OnDelete(DeleteBehavior.Cascade);

            // Связь между таблицами Shift и Employee
            modelBuilder.Entity<Shift>()
                .HasOne(p => p.Employee)
                .WithMany()
                .HasForeignKey(p => p.EmployeeID)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
