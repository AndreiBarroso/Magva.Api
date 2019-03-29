using Magba.Infra.Crosscutting.DataTransferObject;
using Magva.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;

namespace Magva.Infra.Data.Repository
{
    public class CardRespository : ICardRespository
    {
        public CardDto Add(CardDto obj)
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

        public CardDto Update(CardDto obj)
        {
            throw new NotImplementedException();
        }
    }
}
