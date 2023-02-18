using FuelStation.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuelStation.EF.Configurations {
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction> {
        public void Configure(EntityTypeBuilder<Transaction> builder) {
            throw new NotImplementedException();
        }
    }
}
