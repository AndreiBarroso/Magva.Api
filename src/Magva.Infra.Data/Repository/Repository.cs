using Magva.Domain.Interfaces.Repository;
using Magva.Infra.Data.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Magva.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected MagvaDataContext Context;
        protected DbSet<TEntity> DbSet;

        public Repository(MagvaDataContext context)
        {
            Context = context;
            DbSet = Context.Set<TEntity>();
        }

        public TEntity Add(TEntity obj)
        {
            var entry = Context.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Added;

            return obj;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public TEntity GetById(Guid id)
        {
            return DbSet.Find(id);
        }

        public void Remove(Guid id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public TEntity Update(TEntity obj)
        {
            var entry = Context.Entry(obj);
            DbSet.Attach(obj);
            entry.State = EntityState.Modified;

            return obj;
        }
    }
}
