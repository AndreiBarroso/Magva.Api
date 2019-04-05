using Magva.Domain.Shared.Entities;
using System.Collections.Generic;

namespace Magva.Domain.Entities
{
    public class Customer : Entity
    {

        public string Name { get; set; }
        public string Email { get; set; }
        public string Document { get; set; }
        public string Phone { get; set; }


        public virtual IEnumerable<Transaction> Transactions { get; set; }


    }
}
