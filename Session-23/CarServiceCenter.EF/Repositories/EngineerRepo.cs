﻿using CarServiceCenter.EF.Context;
using CarServiceCenter.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Repositories {
    public class EngineerRepo : IEntityRepo<Engineer> {
        public void Add(Engineer entity) {

            using var context = new CarServiceCenterDbContext();
            context.Add(entity);
            context.SaveChanges();
        }

        public void Delete(int id) {

            using var context = new CarServiceCenterDbContext();
            var dbEngineer = context.Engineers.Where(engineer => engineer.Id == id).SingleOrDefault();
            if (dbEngineer is null) {
                return;
            }
            context.Remove(dbEngineer);
            context.SaveChanges();
        }

        public IEnumerable<Engineer> GetAll() {

            using var context = new CarServiceCenterDbContext();
            return context.Engineers.ToList();
        }

        public Engineer? GetById(int id) {

            using var context = new CarServiceCenterDbContext();
            return context.Engineers.Where(engineer => engineer.Id == id).SingleOrDefault();
        }

        public void Update(int id, Engineer entity) {

            using var context = new CarServiceCenterDbContext();
            var dbEngineer = context.Engineers.Where(engineer => engineer.Id == id).SingleOrDefault();
            if (dbEngineer is null) {
                return;
            }
            dbEngineer.Name = entity.Name;
            dbEngineer.Surname = entity.Surname;
            dbEngineer.SalaryPerMonth = entity.SalaryPerMonth;
            context.SaveChanges();
        }
    }
}
