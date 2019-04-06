﻿using System;
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
        private readonly ICardRespository _cardRepository;

        public TransactionService(ITransactionRepository repository,
            ICustomerRepository customerRepository,
            ICardRespository cardRepository)
        {
            _repository = repository;
            _cardRepository = cardRepository;
        }

        public TransactionDto Withdrawal(TransactionDto transactionDto)
        {
            var card = HydrateCardDto(_cardRepository.GetCardByNumberAndSecurityCode(transactionDto.Number, transactionDto.SecurityCode));

            var balanceValidate = new BalanceValidate(card.Balance);


            var transaction = HydrateTransaction(transactionDto, card);

            if (card.Active && balanceValidate.Valid && 
                (card.Number.Equals(transactionDto.Number)))
            {
                _repository.Add(transaction);
            }
            return HydrateTransactionDto(transaction);

        }

        public TransactionDto Deposit(TransactionDto transactionDto)
        {
            var card = _cardRepository.GetCardByNumberAndSecurityCode(transactionDto.Number, transactionDto.SecurityCode);

            var cardDto = HydrateCardDto(card);

            var transaction = HydrateTransaction(transactionDto, cardDto);

            if (cardDto.Active && (cardDto.Number.Equals(transactionDto.Number)))
            {
                _cardRepository.UpdateBalance(card, transaction.Amount);
                _repository.Add(transaction);
            }

            return HydrateTransactionDto(transaction);
        }


        public IEnumerable<TransactionDto> GetAll()
        {
            var transactions =  _repository.GetAllTransaction().Select(x => HydrateTransactionDto(x));
            return transactions;
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

     
        private TransactionDto HydrateTransactionDto(Transaction transaction)
        {
            return new TransactionDto
            {
                Amount = transaction.Amount,
                CardId = transaction.CardId,
                Id = transaction.Id,
                DateTransaction = transaction.DateTransaction,
                NumberInstallments = transaction.NumberInstallments,
                Type = (ETransactionTypeDto)transaction.Type,
                CardholderName = transaction.Card?.Customer.Name,
                Number = transaction.Card?.Number
                
            };
        }

        private Transaction HydrateTransaction(TransactionDto transactionDto, CardDto cardDto)
        {
            return new Transaction
            {
                Amount = transactionDto.Amount,
                Id = transactionDto.Id,
                DateTransaction = transactionDto.DateTransaction,
                NumberInstallments = transactionDto.NumberInstallments,
                Type = (ETransactionType)transactionDto.Type,
                Number = transactionDto.Number,
                CardId = cardDto.Id
            };
        }

        private CardDto HydrateCardDto(Card card)
        {
            return new CardDto
            {
                Active = card.Active,
                Balance = card.Balance,
                CardBrand = card.CardBrand,
                ExpirationDate = card.ExpirationDate,
                Number = card.Number,
                SecurityCode = card.SecurityCode,
                Password = card.Password,
                HasPassword = card.HasPassword,
                Type = (ECardTypeDto)card.Type,
                Id = card.Id,
                CardholderName = card.Customer.Name,
                Document = card.Customer.Document
                
            };
        }


    }

}
