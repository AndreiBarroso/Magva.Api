using DomainValidation.Validation;
using FluentValidator;
using Magva.Domain.Shared.Entities;
using Magva.Domain.Shared.Enum;

namespace Magva.Domain.Entities
{
    public class Card : Entity
    {


        public string Number { get; set; }
        public int SecurityCode { get; set; }
        public string ExpirationDate { get; set; }
        public string CardBrand { get; set; }
        public string Password { get; set; }
        public ECardType Type { get; set; }
        public bool Active { get; set; }
        public bool HasPassword { get; set; }
        public decimal Balance { get; set; }


        public virtual Customer Customer { get; set; }

     
    }
}
