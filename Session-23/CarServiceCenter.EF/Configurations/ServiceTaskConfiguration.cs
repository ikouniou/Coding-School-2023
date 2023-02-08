using CarServiceCenter.Model;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarServiceCenter.EF.Configurations
{
    public class ServiceTaskConfiguration : IEntityTypeConfiguration<ServiceTask>
    {
        public void Configure(EntityTypeBuilder<ServiceTask> builder)
        {
            // Table Name
            builder.ToTable("ServiceTasks");

            // Primary Key
            builder.HasKey(serviceTask => serviceTask.Id);
            builder.Property(serviceTask => serviceTask.Id).ValueGeneratedOnAdd();

            // Properties
            builder.Property(serviceTask => serviceTask.Code).HasMaxLength(50).IsRequired();
            builder.Property(serviceTask => serviceTask.Description).HasMaxLength(100).IsRequired();
            builder.Property(serviceTask => serviceTask.Hours).HasPrecision(3, 2).IsRequired();

            // Relations
        }
    }
}
