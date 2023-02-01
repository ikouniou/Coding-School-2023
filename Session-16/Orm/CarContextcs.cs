using LibCarService;
using Orm.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm {
    public class CarContext : DbContext {

        public DbSet<Car> Cars { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Engineer> Engineers { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<MonthlyLedger> MonthlyLedgers { get; set; }
        public DbSet<ServiceTask> ServiceTasks { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        //public DbSet<TransactionLine> TransactionLines { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            modelBuilder.ApplyConfiguration(new CarConfiguration());

            modelBuilder.ApplyConfiguration(new MonthlyLedgerConfiguration());
            modelBuilder.ApplyConfiguration(new CustomerConfiguration());
            modelBuilder.ApplyConfiguration(new ServiceTaskConfiguration());
            modelBuilder.ApplyConfiguration(new ManagerConfiguration());
            modelBuilder.ApplyConfiguration(new EngineerConfiguration());
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {

            optionsBuilder.UseSqlServer("Data Source=localhost\\SQLEXPRESS;Initial Catalog=CarServiceDb;Integrated Security=True;" +
                "Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
