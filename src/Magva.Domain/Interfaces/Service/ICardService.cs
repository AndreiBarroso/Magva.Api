using Magba.Infra.Crosscutting.DataTransferObject;
using Magva.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Magva.Domain.Interfaces.Service
{
    public interface ICardService
    {
        Card Add(Card card);
        CardDto Update(CardDto cardDto);
        void Remove(Guid id);
        CardDto GetById(Guid id);
        IEnumerable<CardDto> GetAll();

    }
}
