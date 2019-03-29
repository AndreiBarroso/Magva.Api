using Magba.Infra.Crosscutting.DataTransferObject.Enum;
using System;

namespace Magba.Infra.Crosscutting.DataTransferObject
{
    public class TransactionDto
    {
        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public ETransactionTypeDto Type { get; set; }
        public int NumberInstallments { get; set; }
        public DateTime DateTransaction { get; set; }

        public virtual CardDto Card { get; set; }
        public virtual CustomerDto Customer { get; set; }
    }
}
