using Magva.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using Magva.Infra.Data.DataContext;
using Magva.Domain.Entities;
using Magva.Infra.Crosscutting.DataTransferObject;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Magva.Infra.Data.Repository
{
    public class CardRespository : Repository<Card>, ICardRespository
    {
        private readonly MagvaDataContext _context;

        public CardRespository(MagvaDataContext context) : base(context)
        {
            _context = context;
        }

        public IEnumerable<Card> GetByCardAndCustomer()
        {
            return _context
                 .Cards
                 .Include(x => x.Customer)
                 .AsNoTracking()
                 .ToList();
        }


        public Card GetCardByNumberAndSecurityCode(string number, int securityCode)
        {
            return _context
                .Cards
                .Include(x => x.Customer)
                .Where(x => x.Number == number && x.SecurityCode == securityCode)
                .AsNoTracking()
                .FirstOrDefault();
        }


        public CardDto GetCardByIdCustomer(Guid id)
        {
            return _context
                 .Cards
                 .Select(x => new CardDto
                 {
                     Id = x.Id,
                     Balance = x.Balance,
                     CardholderName = x.Customer.Name,
                     Active = x.Active,
                     CardBrand = x.CardBrand,
                     HasPassword = x.HasPassword,
                     Number = x.Number,
                     ExpirationDate = x.ExpirationDate

                 })
                 .AsNoTracking()
                 .Where(x => x.Id == id)
                 .FirstOrDefault();

        }

        public Card GetByCardId(Guid id)
        {
            return _context
                 .Cards
                 .Include(x => x.Customer)
                 .Where(x => x.Id == id)
                 .AsNoTracking()
                 .FirstOrDefault();
        }

        public void UpdateBalance(Card card, decimal balance)
        {
            var _card = new Card
            {
                Id = card.Id,
                Active = card.Active,
                Balance = card.Balance + balance,
                CardBrand = card.CardBrand,
                ExpirationDate = card.ExpirationDate,
                HasPassword = card.HasPassword,
                Number = card.Number,
                Password = card.Password,
                SecurityCode = card.SecurityCode,
                Type = card.Type,
                Customer = card.Customer,
            
            };

            _context.Cards.Attach(_card).Property(x => x.Balance).IsModified = true;

            _context.SaveChanges();

        }
    }
}
