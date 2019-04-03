using System;
using System.Collections.Generic;
using Magva.Infra.Crosscutting.DataTransferObject;
using Magva.Domain.Interfaces.Repository;
using Magva.Domain.Interfaces.Service;
using Magva.Domain.Validations.Customer;

namespace Magva.Service.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly ITransactionRepository _repository;
        private readonly ICustomerRepository _customerRepository;
        private readonly ICardRespository _cardRepository;

        public TransactionService(ITransactionRepository repository,
            ICustomerRepository customerRepository,
            ICardRespository cardRepository)
        {
            _repository = repository;
            _customerRepository = customerRepository;
            _cardRepository = cardRepository;
        }

        public TransactionDto Add(TransactionDto transactionDto)
        {
            var customerCard = _cardRepository.GetCardByIdCustomer(transactionDto.CustomerId);
            var balanceValidate = new BalanceValidate(customerCard.Balance);

            if (customerCard.Active && balanceValidate.Valid)
            {
                return _repository.Add(transactionDto);
            }


            return transactionDto;

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
