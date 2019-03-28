using System.Transactions;

namespace Magva.Domain.Interfaces.Repository
{
    public interface ITransactionRespository
    {
        void Add(Transaction transaction);
    }
}
