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

        public CardDto GetCardByIdCustomer(Guid id)
        {
            return _context
                 .Cards
                 .Select(x => new CardDto
                 {
                     Id = x.Id,
                     Balance = x.Balance,
                     CardholderName = x.CardholderName.Name.ToString(),
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
    }
}
