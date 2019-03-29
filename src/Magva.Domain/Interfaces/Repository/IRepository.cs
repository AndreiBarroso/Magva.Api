using System;
using System.Collections.Generic;

namespace Magva.Domain.Interfaces.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Add(TEntity obj);
        TEntity GetById(Guid id);
        TEntity Update(TEntity obj);
        void Remove(Guid id);
        IEnumerable<TEntity> GetAll();
    }
}
