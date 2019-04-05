using Magva.Domain.Interfaces.Repository;
using Magva.Domain.Entities;
using Magva.Infra.Data.DataContext;

namespace Magva.Infra.Data.Repository
{
    public class TransactionRepository : Repository<Transaction>,  ITransactionRepository
    {

        public TransactionRepository(MagvaDataContext context) : base(context)
        {

        }

        public Transaction Deposit(Transaction transaction)
        {
            throw new System.NotImplementedException();
        }

        public Transaction Withdrawal(Transaction transaction)
        {
            throw new System.NotImplementedException();
        }
    }
}
