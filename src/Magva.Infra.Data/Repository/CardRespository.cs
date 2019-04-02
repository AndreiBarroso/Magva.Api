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
            var card = new CardDto
            {
                ExpirationDate = obj.ExpirationDate,
                CardBrand = obj.CardBrand,
                Password = obj.Password,
                Active = obj.Active,
                HasPassword = obj.HasPassword,
                Number = obj.Number

            };
            _context.Entry<CardDto>(card)
                .State = EntityState.Added;
            _context.SaveChanges();

            return card;
        }

        public IEnumerable<CardDto> GetAll()
        {
            return _context
                .Cards
                .Select(x => new CardDto
                {
                    Id = x.Id,
                    ExpirationDate = x.ExpirationDate,
                    Number = x.Number,
                    Active = x.Active,
                    CardBrand = x.CardBrand,
                    HasPassword = x.HasPassword,
                    Password = x.Password,

                });
        }

        public CardDto GetById(Guid id)
        {
            return _context
                .Cards
                .Select(x => new CardDto
                {
                    Id = x.Id,
                    ExpirationDate = x.ExpirationDate,
                    Number = x.Number,
                    Active = x.Active,
                    CardBrand = x.CardBrand,
                    HasPassword = x.HasPassword,
                    Password = x.Password,

                })
                .AsNoTracking()
                .Where(x => x.Id == id)
                .FirstOrDefault();
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
            var card = GetById(id);
            _context.Remove(card);
            _context.SaveChanges();
        }

        public CardDto Update(CardDto obj)
        {
            var card = new CardDto
            {
                ExpirationDate = obj.ExpirationDate,
                CardBrand = obj.CardBrand,
                Password = obj.Password,
                Active = obj.Active,
                HasPassword = obj.HasPassword,
                Number = obj.Number

            };
            _context.Entry<CardDto>(card)
                .State = EntityState.Modified;
            _context.SaveChanges();

            return card;
        }
    }
}
