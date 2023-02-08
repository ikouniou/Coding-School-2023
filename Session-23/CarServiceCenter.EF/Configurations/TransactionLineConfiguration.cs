using CarServiceCenter.Model;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarServiceCenter.EF.Configurations
{
    public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine>
    {
        public void Configure(EntityTypeBuilder<TransactionLine> builder)
        {
            // Table Name
            builder.ToTable("TransactionLines");

            // Primary Key
            builder.HasKey(transactionLine => transactionLine.Id);
            builder.Property(transactionLine => transactionLine.Id).ValueGeneratedOnAdd();

            // Properties
            builder.Property(transactionLine => transactionLine.Hours).HasPrecision(3, 2).IsRequired();
            builder.Property(transactionLine => transactionLine.PricePerHour).HasPrecision(3, 2).IsRequired();
            builder.Property(transactionLine => transactionLine.Price).HasPrecision(9, 2).IsRequired();

            // Relations
            builder.HasOne(transactionLine => transactionLine.Transaction)
                .WithMany(transaction => transaction.TransactionLines)
                .HasForeignKey(transactionLine => transactionLine.TransactionId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(transactionLine => transactionLine.ServiceTask)
                .WithMany(serviceTask => serviceTask.TransactionLines)
                .HasForeignKey(transactionLine => transactionLine.ServiceTaskId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(transactionLine => transactionLine.Engineer)
                .WithMany(engineer => engineer.TransactionLines)
                .HasForeignKey(transactionLine => transactionLine.EngineerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
