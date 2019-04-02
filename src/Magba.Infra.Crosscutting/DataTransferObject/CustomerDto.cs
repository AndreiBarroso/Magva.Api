using Magva.Infra.Crosscutting.DataTransferObject.ValueObject;
using System;

namespace Magva.Infra.Crosscutting.DataTransferObject
{
    public class CustomerDto
    {
        public Guid Id { get; set; }
        public NameDto Name { get; set; }
        public EmailDto Email { get; set; }
        public DateTime BirthDate { get; set; }
        public DocumentDto Document { get; set; }
        public string Phone { get; set; }
        public decimal Balance { get; set; }

        public TransactionDto[] Transactions { get; set; }
    }
}
