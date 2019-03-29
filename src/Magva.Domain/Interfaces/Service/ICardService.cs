using Magba.Infra.Crosscutting.DataTransferObject;
using System;
using System.Collections.Generic;

namespace Magva.Domain.Interfaces.Service
{
    public interface ICardService
    {
        CardDto Add(CardDto cardDto);
        CardDto Update(CardDto cardDto);
        void Remove(Guid id);
        CardDto GetById(Guid id);
        IEnumerable<CardDto> GetAll();

    }
}
