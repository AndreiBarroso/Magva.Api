using Magva.Infra.Crosscutting.DataTransferObject.Enum;
using System;

namespace Magva.Infra.Crosscutting.DataTransferObject
{
    public class TransactionDto
    {
        public TransactionDto()
        {
            DateTransaction = DateTime.Now;
        }
        public Guid Id { get; set; }
        public decimal Amount { get; set; }
        public ETransactionTypeDto Type { get; set; }
        public int NumberInstallments { get; set; }
        public DateTime DateTransaction { get; set; }
        public string CardholderName { get; set; }
        public string Number { get; set; }
        public int SecurityCode { get; set; }

        public string Document { get; set; }
        public Guid CardId { get; set; }
        public Guid CustomerId { get; set; }


    }
}
