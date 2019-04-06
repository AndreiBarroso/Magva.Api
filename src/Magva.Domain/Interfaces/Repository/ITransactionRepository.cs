using Magva.Domain.Entities;
using System.Collections.Generic;

namespace Magva.Domain.Interfaces.Repository
{
    public interface ITransactionRepository : IRepository<Transaction>
    {
        IEnumerable<Transaction> GetAllTransaction();
    }
}
