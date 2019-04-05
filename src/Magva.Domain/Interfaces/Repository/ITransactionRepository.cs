using Magva.Domain.Entities;

namespace Magva.Domain.Interfaces.Repository
{
    public interface ITransactionRepository : IRepository<Transaction>
    {


        Transaction Withdrawal(Transaction transaction);
        Transaction Deposit(Transaction transaction);
    }
}
