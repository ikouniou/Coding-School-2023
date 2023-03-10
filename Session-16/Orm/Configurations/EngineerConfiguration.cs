using LibCarService;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Configurations {
    public class EngineerConfiguration : IEntityTypeConfiguration<Engineer> {
        public void Configure(EntityTypeBuilder<Engineer> builder) {

            builder.ToTable("Engineer");

            builder.HasKey(engineer => engineer.ID);
            builder.Property(engineer => engineer.Name).HasMaxLength(50).IsRequired(true);
            builder.Property(engineer => engineer.Surname).HasMaxLength(50).IsRequired(true);

            //RELATIONS
            builder.HasOne(engineer => engineer.Manager)
                .WithMany(manager => manager.Engineers)
                .HasForeignKey(enginner => enginner.ManagerID);
        }
    }
}
