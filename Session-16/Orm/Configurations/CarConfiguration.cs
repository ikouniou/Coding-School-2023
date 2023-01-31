﻿using LibCarService;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Configurations {
    public class CarConfiguration : IEntityTypeConfiguration<Car> {
        public void Configure(EntityTypeBuilder<Car> builder) {

            builder.ToTable("Car");

            builder.HasKey(car => car.ID);

            builder.Property(car => car.Model).HasMaxLength(100).IsRequired(true);

            builder.Property(car => car.Brand).HasMaxLength(100).IsRequired(true);

            builder.Property(car => car.CarRegistrationNumber).HasMaxLength(100).IsRequired(true);
        }
    }
}
