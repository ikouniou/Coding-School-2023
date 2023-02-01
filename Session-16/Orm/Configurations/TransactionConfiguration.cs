using LibCarService;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Configurations {
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction> {
        public void Configure(EntityTypeBuilder<Transaction> builder) {

            builder.ToTable("Transaction");

            builder.HasKey(transaction => transaction.ID);

            //RELATIONS
            builder.HasOne(transaction => transaction.Car)
                .WithOne(car => car.Transaction)
                .HasForeignKey<Transaction>(transaction => transaction.CarID);

            builder.HasOne(transaction => transaction.Customer)
                .WithOne(customer => customer.Transaction)
                .HasForeignKey<Transaction>(transaction => transaction.CustomerID);

            builder.HasOne(transaction => transaction.Manager)
                .WithOne(manager => manager.Transaction)
                .HasForeignKey<Transaction>(transaction => transaction.ManagerID);
        }
    }
}
