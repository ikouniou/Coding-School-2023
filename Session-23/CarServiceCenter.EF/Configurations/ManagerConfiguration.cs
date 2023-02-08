using CarServiceCenter.Model;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarServiceCenter.EF.Configurations
{
    public class ManagerConfiguration : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            // Table Name
            builder.ToTable("Managers");

            // Primary Key
            builder.HasKey(manager => manager.Id);
            builder.Property(manager => manager.Id).ValueGeneratedOnAdd();

            // Properties
            builder.Property(manager => manager.Name).HasMaxLength(50).IsRequired();
            builder.Property(manager => manager.Surname).HasMaxLength(100).IsRequired();
            builder.Property(manager => manager.SalaryPerMonth).IsRequired();

            // Relations
        }
    }
}
