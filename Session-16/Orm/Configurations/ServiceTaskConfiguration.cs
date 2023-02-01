using LibCarService;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Configurations {
    public class ServiceTaskConfiguration : IEntityTypeConfiguration<ServiceTask> {
        public void Configure(EntityTypeBuilder<ServiceTask> builder) {

            builder.ToTable("ServiceTask");

            builder.HasKey(serviceTask => serviceTask.ID);

            builder.Property(serviceTask => serviceTask.Description).HasMaxLength(200).IsRequired(true);

        }
    }
}
