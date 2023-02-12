using CarServiceCenter.EF.Context;
using CarServiceCenter.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Repositories {
    public class TransactionLineRepo : IEntityRepo<TransactionLine> {
        public void Add(TransactionLine entity) {

            using var context = new CarServiceCenterDbContext();
            if (entity.Id != 0)
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id) {

            using var context = new CarServiceCenterDbContext();
            var dbTransactionLine = context.TransactionLines.Where(transactionLine => transactionLine.Id == id).SingleOrDefault();
            if (dbTransactionLine is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            context.Remove(dbTransactionLine);
            context.SaveChanges();
        }

        public IEnumerable<TransactionLine> GetAll() {

            using var context = new CarServiceCenterDbContext();
            return context.TransactionLines.Include(transactionLine => transactionLine.Transaction).Include(transactionLine => transactionLine.ServiceTask)
                .Include(transactionLine => transactionLine.Engineer).ToList();
        }

        public TransactionLine? GetById(int id) {

            using var context = new CarServiceCenterDbContext();
            return context.TransactionLines.Where(transactionLine => transactionLine.Id == id).Include(transactionLine => transactionLine.Transaction).Include(transactionLine => transactionLine.ServiceTask)
                .Include(transactionLine => transactionLine.Engineer).SingleOrDefault();
        }

        public void Update(int id, TransactionLine entity) {

            using var context = new CarServiceCenterDbContext();
            var dbTransactionLine = context.TransactionLines.Where(transactionLine => transactionLine.Id == id).SingleOrDefault();
            if (dbTransactionLine is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            dbTransactionLine.Hours = entity.Hours;
            dbTransactionLine.PricePerHour = entity.PricePerHour;
            dbTransactionLine.Price = entity.Price;
            dbTransactionLine.TransactionId = entity.TransactionId;
            dbTransactionLine.ServiceTaskId = entity.ServiceTaskId;
            dbTransactionLine.EngineerId = entity.EngineerId;
            context.SaveChanges();
        }
    }
}
