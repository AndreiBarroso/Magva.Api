using System;

namespace Magba.Infra.Crosscutting.DataTransferObject
{
    public class AddressDto
    {
        public Guid Id { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string Complement { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string ZipeCode { get; set; }
    }
}
