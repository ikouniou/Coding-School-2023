﻿using PetShop.EF.Context;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetShop.EF.Repositories
{
    public class TransactionRepo : IEntityRepo<Transaction>
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
            throw new KeyNotFoundException($"Given id'{id}' was not found in database");
        }
        context.Remove(dbTransaction);
        context.SaveChanges();
    }
public IList<Transaction> GetAll()
    {
        using var context = new TransactionDbContext();
        return context.Transactions.ToList();
    }
    public Transaction? GetById(int id)
    {
        using var context = new TransactionDbContext();
        return context.Transaction.SingleOrDefault(Trasaction => Transaction.Id == id);
    }
    public void Update(int id, Transaction entity) {
        using var context = new TransactionDpContext();
        var dbTransaction = context.Transactions.SingleOrDefault(transaction => transaction.Id == id);
        if (dbTrasaction is null)
        {
            throw new KeyNotFoundException($"Given id '{id}' was not found in database");
        }
        dbTransaction.PetPrice = entity.PetPrice;
        dbTransaction.TotalPrice = entity.TotalPrice;
        dbTransaction.PetFoodQty = entity.PetFoodQty;
        dbTransaction.Date = entity.Date;
        dbTransaction.PetFoodPrice = entity.PetFoodPrice;
        context.SaveChanges();

    }
}
