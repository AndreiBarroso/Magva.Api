using Magba.Infra.Crosscutting.DataTransferObject;
using Magva.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Magva.Domain.Interfaces.Service
{
    public interface ITransactionService
    {
        Transaction Add(Transaction transaction);
        TransactionDto Update(TransactionDto transactionDto);
        void Remove(Guid id);
        TransactionDto GetById(Guid id);
        IEnumerable<TransactionDto> GetAll();
    }
}
