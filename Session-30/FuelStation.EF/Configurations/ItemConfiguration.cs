using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configurations {
    public class ItemConfiguration : IEntityTypeConfiguration<Item> {
        public void Configure(EntityTypeBuilder<Item> builder) {
            throw new NotImplementedException();
        }
    }
}
