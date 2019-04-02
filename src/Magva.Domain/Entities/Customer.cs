using Magva.Domain.Shared.Entities;
using Magva.Domain.Shared.ValueObject;
using System;
using System.Collections.Generic;

namespace Magva.Domain.Entities
{
    public class Customer : Entity
    {

        public Name Name { get; set; }
        public Email Email { get; set; }
        public DateTime BirthDate { get; set; }
        public Document Document { get; set; }
        public string Phone { get; set; }
        public decimal Balance { get; set; }

        public virtual IEnumerable<Transaction> Transactions { get; set; }


    }
}
