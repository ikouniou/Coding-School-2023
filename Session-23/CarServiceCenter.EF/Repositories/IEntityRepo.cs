﻿using CarServiceCenter.Model;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarServiceCenter.EF.Repositories {
    public interface IEntityRepo<TEntity> 
        where TEntity : IEntityBase
    {
        IEnumerable<TEntity> GetAll();
        TEntity? GetById(int id);
        void Add(TEntity entity);
        void Update(int id, TEntity entity);
        void Delete(int id);
    }
}
