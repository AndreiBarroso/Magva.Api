using Magva.Infra.Crosscutting.DataTransferObject;
using System;

namespace Magva.Domain.Interfaces.Repository
{
    public interface ICardRespository : IRepository<CardDto>
    {
        CardDto GetCardByIdCustomer(Guid id);
    }
}
