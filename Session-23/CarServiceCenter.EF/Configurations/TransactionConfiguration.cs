using CarServiceCenter.Model;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarServiceCenter.EF.Configurations
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
            // Table Name
            builder.ToTable("Transactions");

            // Primary Key
            builder.HasKey(transaction => transaction.Id);
            builder.Property(transaction => transaction.Id).ValueGeneratedOnAdd();

            // Properties
            builder.Property(transaction => transaction.Date).IsRequired();
            builder.Property(transaction => transaction.TotalPrice).HasPrecision(9, 2).IsRequired();

            // Relations
            builder.HasOne(transaction => transaction.Customer)
                .WithMany(customer => customer.Transactions)
                .HasForeignKey(transaction => transaction.CustomerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(transaction => transaction.Manager)
                .WithMany(manager => manager.Transactions)
                .HasForeignKey(transaction => transaction.ManagerId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(transaction => transaction.Car)
                .WithMany(car => car.Transactions)
                .HasForeignKey(transaction => transaction.CarId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
