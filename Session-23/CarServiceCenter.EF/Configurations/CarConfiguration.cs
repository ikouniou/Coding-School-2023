using CarServiceCenter.Model;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarServiceCenter.EF.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            // Table Name
            builder.ToTable("Cars");

            // Primary Key
            builder.HasKey(car => car.Id);
            builder.Property(car => car.Id).ValueGeneratedOnAdd();

            // Properties
            builder.Property(car => car.Brand).HasMaxLength(30).IsRequired();
            builder.Property(car => car.Model).HasMaxLength(50).IsRequired();
            builder.Property(car => car.CarRegistrationNumber).HasMaxLength(10).IsRequired();

            // Relations

        }
    }
}
