using Magva.Domain.Entities;
using Magva.Infra.Crosscutting.DataTransferObject;
using System;

namespace Magva.Domain.Interfaces.Repository
{
    public interface ICardRespository : IRepository<Card>
    {
        CardDto GetCardByIdCustomer(Guid id);
    }
}
