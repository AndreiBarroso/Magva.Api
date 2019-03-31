using Magva.Infra.Crosscutting.DataTransferObject;
using System;
using System.Collections.Generic;

namespace Magva.Domain.Interfaces.Service
{
    public interface ICustomerService
    {
        CustomerDto Register(CustomerDto customer);
        CustomerDto Update(CustomerDto customerDto);
        CustomerDto GetCustomerById(Guid id);
        IEnumerable<CustomerDto> GetAllCustomers();
        void Delete(Guid id);
    }
}
