using LibCarService;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orm.Configurations {
    public class TransactionLineConfiguration : IEntityTypeConfiguration<TransactionLine> {
        public void Configure(EntityTypeBuilder<TransactionLine> builder) {

            builder.ToTable("TransactionLine");
            builder.HasKey(transactionLine => transactionLine.ID);

            //RELATIONS
            builder.HasOne(transactionLine => transactionLine.Engineer)
                .WithMany(engineer => engineer.TransactionLines)
                .HasForeignKey(transactionLine => transactionLine.EngineerID);

            builder.HasOne(transactionLine => transactionLine.Transaction)
                .WithMany(transaction => transaction.Lines)
                .HasForeignKey(transactionLine => transactionLine.TransactionID);


            builder.HasOne(transactionLine => transactionLine.ServiceTask)
                .WithOne(serviceTask => serviceTask.TransactionLine)
                .HasForeignKey<TransactionLine>(transactionLine => transactionLine.ServiceTaskID);
        }
    }
}
