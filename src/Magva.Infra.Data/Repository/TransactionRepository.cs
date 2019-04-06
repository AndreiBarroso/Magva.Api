using Magva.Domain.Interfaces.Repository;
using Magva.Domain.Entities;
using Magva.Infra.Data.DataContext;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Magva.Infra.Data.Repository
{
    public class TransactionRepository : Repository<Transaction>, ITransactionRepository
    {
        private readonly MagvaDataContext _context;

        public TransactionRepository(MagvaDataContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Transaction> GetAllTransaction()
        {
            return _context
                .Transactions
                .Include(x => x.Card)
                .Include(x => x.Card.Customer)
                .AsNoTracking()
                .ToList();
        }
    }
}
