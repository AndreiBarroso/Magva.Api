using Magva.Infra.Crosscutting.DataTransferObject;
using Magva.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using Magva.Infra.Data.DataContext;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Magva.Infra.Data.Repository
{
    public class CardRespository : ICardRespository
    {
        private readonly MagvaDataContext _context;

        public CardRespository(MagvaDataContext context)
        {
            _context = context;
        }

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

        public CardDto GetCardByIdCustomer(Guid id)
        {
            return _context
                .Cards
                .Select(x => new CardDto
                {
                    Id = x.Id,
                    CardBrand = x.CardBrand,
                    ExpirationDate = x.ExpirationDate,
                    Number = x.Number,
                    HasPassword = x.HasPassword,
                    Password = x.Password,
                })
              .AsNoTracking()
              .Where(x => x.CardholderNameId.Id == id)
              .FirstOrDefault();
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
