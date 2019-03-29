using Magva.Domain.Shared.Entities;
using Magva.Domain.Shared.Enum;
using System;

namespace Magva.Domain.Entities
{
    public class Transaction : Entity
    {

        public decimal Amount { get; set; }
        public ETransactionType Type { get; set; }
        public int NumberInstallments { get; set; }
        public DateTime DateTransaction { get; set; }

        public virtual Card Card { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
