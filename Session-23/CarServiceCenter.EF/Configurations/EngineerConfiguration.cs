using CarServiceCenter.Model;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarServiceCenter.EF.Configurations
{
    public class EngineerConfiguration : IEntityTypeConfiguration<Engineer>
    {
        public void Configure(EntityTypeBuilder<Engineer> builder)
        {
            // Table Name
            builder.ToTable("Engineers");

            // Primary Key
            builder.HasKey(engineer => engineer.Id);
            builder.Property(engineer => engineer.Id).ValueGeneratedOnAdd();

            // Properties
            builder.Property(engineer => engineer.Name).HasMaxLength(50).IsRequired();
            builder.Property(engineer => engineer.Surname).HasMaxLength(100).IsRequired();
            builder.Property(engineer => engineer.SalaryPerMonth).IsRequired();

            // Relations
            builder.HasOne(engineer => engineer.Manager)
                .WithMany(manager => manager.Engineers)
                .HasForeignKey(engineer => engineer.ManagerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
