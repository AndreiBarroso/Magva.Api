using Magva.Domain.Shared.Entities;
using Magva.Domain.Shared.Enum;
using System;

namespace Magva.Domain.Entities
{
    public class Transaction : Entity
    {
        public Transaction()
        {
            DateTransaction = DateTime.Now;
        }

        public decimal Amount { get; set; }
        public ETransactionType Type { get; set; }
        public int NumberInstallments { get; set; }
        public DateTime DateTransaction { get; set; }
        public string  Number { get; set; }
        public Guid CardId { get; set; }

        public virtual Card Card { get; set; }
    }
}
