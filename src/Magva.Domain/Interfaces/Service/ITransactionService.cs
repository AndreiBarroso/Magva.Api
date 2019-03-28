using System.Transactions;

namespace Magva.Domain.Interfaces.Service
{
    public interface ITransactionService
    {
        void Add(Transaction transaction);
    }
}
