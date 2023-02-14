using PetShop.EF.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repositories
{
    public class TransactionRepo : IEntityRepo<TransactionRepo>
    {
        public void Add(TransactionRepo entity)
        {
            using var context = new PetShopDbContext();
            if (entity != 0 ) {
                throw new ArgumentException("Given entity should Have ID set,", nameof(entity));
            }
            context.Add(entity);
            context.SaveChanges();
        }
    }
    public void Delete(int id)
    {
        using var context = new PetShopDbContext();
        var dbTransaction = context.Transactions.SingleOrDefault(transaction => transaction.Id == id);
        if (dbTransaction is null)
        {

        }
    }
}
