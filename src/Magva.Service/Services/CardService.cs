using System;
using System.Collections.Generic;
using Magva.Infra.Crosscutting.DataTransferObject;
using Magva.Domain.Interfaces.Repository;
using Magva.Domain.Interfaces.Service;

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
            return _repository.Add(cardDto);
        }

        public IEnumerable<CardDto> GetAll()
        {
            return _repository.GetAll();
        }

        public CardDto GetById(Guid id)
        {
            return GetById(id);
        }

        public void Remove(Guid id)
        {
            _repository.Remove(id);
        }

        public CardDto Update(CardDto cardDto)
        {
            return _repository.Update(cardDto);
        }
    }
}
