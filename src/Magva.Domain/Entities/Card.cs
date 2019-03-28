using Magva.Domain.Shared.Enum;
using System;

namespace Magva.Domain.Entities
{
    public class Card
    {
        public Customer CardholderName { get; set; }
        public string Number { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string CardBrand { get; set; }
        public string Password { get; set; }
        public ECardType Type { get; set; }
        public bool HasPassword { get; set; }
    }
}
