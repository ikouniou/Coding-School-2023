using LibCarService;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Configurations {
    public class ManagerConfiguration : IEntityTypeConfiguration<Manager> {
        public void Configure(EntityTypeBuilder<Manager> builder) {

            builder.ToTable("Manager");

            builder.HasKey(manager => manager.ID);
            builder.Property(manager => manager.Name).HasMaxLength(50).IsRequired(true);
            builder.Property(manager => manager.Surname).HasMaxLength(50).IsRequired(true);
        }
    }
}
