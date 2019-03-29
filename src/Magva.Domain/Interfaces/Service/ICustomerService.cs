using Magba.Infra.Crosscutting.DataTransferObject;
using Magva.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Magva.Domain.Interfaces.Service
{
    public interface ICustomerService
    {
        Customer Register(Customer customer);
        CustomerDto Update(CustomerDto customer);
        CustomerDto GetCustomerById(Guid id);
        IEnumerable<CustomerDto> GetAllCustomers();
        void Delete(Guid id);
    }
}
