using Magba.Infra.Crosscutting.DataTransferObject;
using Magva.Domain.Entities;
using Magva.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;

namespace Magva.Infra.Data.Repository
{
    public class CustomerRepository : ICustomerRespository
    {
        public CustomerDto Add(CustomerDto obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public CustomerDto GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public CustomerDto Update(CustomerDto obj)
        {
            throw new NotImplementedException();
        }
    }
}
