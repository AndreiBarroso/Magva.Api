using System;
using System.Collections.Generic;
using Magba.Infra.Crosscutting.DataTransferObject;
using Magva.Domain.Entities;
using Magva.Domain.Interfaces.Repository;
using Magva.Domain.Interfaces.Service;

namespace Magva.Service.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRespository _repository;

        public TransactionService(ITransactionRespository repository)
        {
            _repository = repository;
        }

        public Transaction Add(Transaction transaction)
        {
            return _repository.Add(transaction);
        }

        public IEnumerable<TransactionDto> GetAll()
        {
           
        }

        public TransactionDto GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public TransactionDto Update(TransactionDto transactionDto)
        {
            throw new NotImplementedException();
        }
    }
}
