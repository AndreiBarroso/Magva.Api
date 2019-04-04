using System;
using System.Collections.Generic;
using Magva.Infra.Crosscutting.DataTransferObject;
using Magva.Domain.Interfaces.Repository;
using Magva.Domain.Interfaces.Service;
using Magva.Domain.Entities;
using Magva.Infra.Crosscutting.DataTransferObject.Enum;
using Magva.Domain.Shared.Enum;
using System.Linq;

namespace Magva.Service.Services
{
    public class CardService : ICardService
    {
        private readonly ICardRespository _repository;

        public CardService(ICardRespository repository)
        {
            _repository = repository;
        }

        public CardDto Add(CardDto cardDto)
        {
            var card = HydrateCard(cardDto);
             _repository.Add(card);

            return HydrateCardDto(card);
        }

        public IEnumerable<CardDto> GetAll()
        {
            return _repository.GetAll().Select(x => HydrateCardDto(x));
        }

        public CardDto GetById(Guid id)
        {
            var card = _repository.GetById(id);
            return HydrateCardDto(card);
        }

        public void Remove(Guid id)
        {
            _repository.Remove(id);
        }

        public CardDto Update(CardDto cardDto)
        {
            var card = HydrateCard(cardDto);
            _repository.Update(card);
            return HydrateCardDto(card);
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
                FirstName = card.Customer.Name.FirstName,
                LastName = card.Customer.Name.LastName,
                Id = card.Id
            };
        }

        private Card HydrateCard(CardDto cardDto)
        {
            return new Card
            {
                Active = cardDto.Active,
                Balance = cardDto.Balance,
                CardBrand = cardDto.CardBrand,
                ExpirationDate = cardDto.ExpirationDate,
                Number = cardDto.Number,
                SecurityCode = cardDto.SecurityCode,
                Password = cardDto.Password,
                HasPassword = cardDto.HasPassword,
                Type = (ECardType)cardDto.Type,
                CardholderName = (cardDto.FirstName + ' ' + cardDto.LastName),
                Id = cardDto.Id
            };
        }
    }
}
