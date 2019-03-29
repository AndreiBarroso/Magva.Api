using System;
using System.Collections.Generic;
using Magba.Infra.Crosscutting.DataTransferObject;
using Magva.Domain.Entities;
using Magva.Domain.Interfaces.Repository;
using Magva.Domain.Interfaces.Service;

namespace Magva.Service.Services
{
    public class CardService : ICardService
    {
        private readonly ICardRespository _repostirody;

        public CardService(ICardRespository repostirody)
        {
            _repostirody = repostirody;
        }

        public Card Add(Card card)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CardDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public CardDto GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public CardDto Update(CardDto cardDto)
        {
            throw new NotImplementedException();
        }
    }
}
