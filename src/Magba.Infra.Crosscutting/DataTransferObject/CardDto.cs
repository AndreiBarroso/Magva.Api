﻿using Magva.Infra.Crosscutting.DataTransferObject.Enum;
using System;

namespace Magva.Infra.Crosscutting.DataTransferObject
{
    public class CardDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Number { get; set; }
        public int SecurityCode { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string CardBrand { get; set; }
        public string Password { get; set; }
        public ECardTypeDto Type { get; set; }
        public bool HasPassword { get; set; }
        public bool Active { get; set; }
        public decimal Balance { get; set; }
    }
}
