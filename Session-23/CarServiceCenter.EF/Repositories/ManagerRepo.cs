using CarServiceCenter.EF.Context;
using CarServiceCenter.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Repositories {
    public class ManagerRepo : IEntityRepo<Manager> {
        public void Add(Manager entity) {

            using var context = new CarServiceCenterDbContext();
            if (entity.Id != 0)
                throw new ArgumentException("Given entity should not have Id set", nameof(entity));
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id) {

            using var context = new CarServiceCenterDbContext();
            var dbManager = context.Managers.Where(manager => manager.Id == id).SingleOrDefault();
            if (dbManager is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            context.Remove(dbManager);
            context.SaveChanges();
        }

        public IEnumerable<Manager> GetAll() {

            using var context = new CarServiceCenterDbContext();
            return context.Managers.Include(manager => manager.Transactions).Include(manager => manager.Engineers).ToList();
        }

        public Manager? GetById(int id) {

            using var context = new CarServiceCenterDbContext();
            return context.Managers.Where(manager => manager.Id == id).Include(manager => manager.Transactions).Include(manager => manager.Engineers).SingleOrDefault();
        }

        public void Update(int id, Manager entity) {

            using var context = new CarServiceCenterDbContext();
            var dbManager = context.Managers.Where(manager => manager.Id == id).SingleOrDefault();
            if (dbManager is null) {
                throw new KeyNotFoundException($"Given id '{id}' was not found in database");
            }
            dbManager.Name = entity.Name;
            dbManager.Surname = entity.Surname;
            dbManager.SalaryPerMonth = entity.SalaryPerMonth;
            context.SaveChanges();
        }
    }
}
