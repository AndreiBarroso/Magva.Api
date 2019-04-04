using Magva.Infra.Crosscutting.DataTransferObject.ValueObject;
using System;

namespace Magva.Infra.Crosscutting.DataTransferObject
{
    public class CustomerDto
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public string Document { get; set; }
        public string Phone { get; set; }

        public TransactionDto[] Transactions { get; set; }
    }
}
