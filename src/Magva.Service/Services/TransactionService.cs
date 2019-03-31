using System;
using System.Collections.Generic;
using Magva.Infra.Crosscutting.DataTransferObject;
using Magva.Domain.Interfaces.Repository;
using Magva.Domain.Interfaces.Service;

namespace Magva.Service.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _repository;
        private readonly ICustomerRepository _customerRepository;

        public TransactionService(ITransactionRepository repository, ICustomerRepository customerRepository)
        {
            _repository = repository;
            _customerRepository = customerRepository;
        }

        public TransactionDto Add(TransactionDto transaction)
        {
           var CostomerBalance = _customerRepository.BalanceCustomer(transaction.CustomerId);
            
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
