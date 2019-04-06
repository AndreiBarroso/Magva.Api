using Magva.Domain.Entities;
using Magva.Infra.Crosscutting.DataTransferObject;
using System;
using System.Collections.Generic;

namespace Magva.Domain.Interfaces.Repository
{
    public interface ICardRespository : IRepository<Card>
    {
        CardDto GetCardByIdCustomer(Guid id);
        Card GetCardByNumberAndSecurityCode(string number, int securityCode);
        IEnumerable<Card> GetByCardAndCustomer();
        Card GetByCardId(Guid id);
        void UpdateBalance(Card card, decimal balance);
    }
}
