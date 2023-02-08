using CarServiceCenter.Model;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarServiceCenter.EF.Configurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            // Table Name
            builder.ToTable("Customers");

            // Primary Key
            builder.HasKey(customer => customer.Id);
            builder.Property(customer => customer.Id).ValueGeneratedOnAdd();

            // Properties
            builder.Property(customer => customer.Name).HasMaxLength(50).IsRequired();
            builder.Property(customer => customer.Name).HasMaxLength(50).IsRequired();
            builder.Property(customer => customer.Surname).HasMaxLength(100).IsRequired();
            builder.Property(customer => customer.Phone).HasMaxLength(15).IsRequired();
            builder.Property(customer => customer.Tin).HasMaxLength(30).IsRequired();

            // Relations

        }
    }
}
