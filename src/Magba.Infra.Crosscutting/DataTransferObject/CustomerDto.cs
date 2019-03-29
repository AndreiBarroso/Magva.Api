using Magba.Infra.Crosscutting.DataTransferObject.ValueObject;
using System;

namespace Magba.Infra.Crosscutting.DataTransferObject
{
    public class CustomerDto
    {
        public Guid Id { get; set; }
        public NameDto Name { get; set; }
        public EmailDto Email { get; set; }
        public DateTime BirthDate { get; set; }
        public DocumentDto Document { get; set; }
        public string Phone { get; set; }

        public TransactionDto[] Transactions { get; set; }
        public Guid AddressId { get; set; }
    }
}
