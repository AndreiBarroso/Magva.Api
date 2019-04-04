using System;
using System.Collections.Generic;
using Magva.Infra.Crosscutting.DataTransferObject;
using Magva.Domain.Interfaces.Repository;
using Magva.Domain.Interfaces.Service;
using Magva.Domain.Validations.Customer;
using System.Linq;
using Magva.Domain.Entities;
using Magva.Infra.Crosscutting.DataTransferObject.Enum;
using Magva.Domain.Shared.Enum;

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

            var transaction = HydrateTransaction(transactionDto);

            if (customerCard.Active && balanceValidate.Valid)
            {
          
                 _repository.Add(transaction);
            }

            return HydrateTransactionDto(transaction);

        }

        public IEnumerable<TransactionDto> GetAll()
        {
            return _repository.GetAll().Select(x => HydrateTransactionDto(x));
        }

        public TransactionDto GetById(Guid id)
        {
            var transaction = _repository.GetById(id);
            return HydrateTransactionDto(transaction);

        }

        public void Remove(Guid id)
        {
            _repository.Remove(id);
        }

        public TransactionDto Update(TransactionDto transactionDto)
        {
            var transaction = HydrateTransaction(transactionDto);
            _repository.Update(transaction);
            return HydrateTransactionDto(transaction);
        }

        private TransactionDto HydrateTransactionDto(Transaction transaction)
        {
            return new TransactionDto
            {
                Amount = transaction.Amount,
                CardId = transaction.Card.Id,
                Id = transaction.Id,
                CustomerId = transaction.Customer.Id,
                DateTransaction = transaction.DateTransaction,
                NumberInstallments = transaction.NumberInstallments,
                Type = (ETransactionTypeDto)transaction.Type,
            };
        }

        private Transaction HydrateTransaction(TransactionDto transactionDto)
        {
            return new Transaction
            {
                Amount = transactionDto.Amount,
                Id = transactionDto.Id,
                DateTransaction = transactionDto.DateTransaction,
                NumberInstallments = transactionDto.NumberInstallments,
                Type = (ETransactionType)transactionDto.Type,
            };
        }
    }

}
