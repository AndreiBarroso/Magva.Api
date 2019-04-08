using Magva.Infra.Crosscutting.DataTransferObject.Enum;
using System;

namespace Magva.Infra.Crosscutting.DataTransferObject
{
    public class CardDto
    {
        public Guid Id { get; set; }
        public string Number { get; set; }
        public int SecurityCode { get; set; }
        public string ExpirationDate { get; set; }
        public string CardBrand { get; set; }
        public string Password { get; set; }
        public ECardTypeDto Type { get; set; }
        public bool HasPassword { get; set; }
        public bool Active { get; set; }
        public decimal Balance { get; set; }
        public Guid CustomerId { get; set; }
        public string Document { get; set; }
        public string CardholderName { get; set; }
        public string Message { get; set; }


    }
}
