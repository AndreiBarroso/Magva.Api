using System;
using System.Collections.Generic;
using Magba.Infra.Crosscutting.DataTransferObject;
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

        public TransactionDto Add(TransactionDto transaction)
        {
            return _repository.Add(transaction);
        }

        public IEnumerable<TransactionDto> GetAll()
        {
            return _repository.GetAll();
        }

        public TransactionDto GetById(Guid id)
        {
            return _repository.GetById(id);
        }

        public void Remove(Guid id)
        {
            _repository.Remove(id);
        }

        public TransactionDto Update(TransactionDto transactionDto)
        {
            return _repository.Update(transactionDto);
        }
    }

}
