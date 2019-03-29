using Magva.Domain.Entities;
using Magva.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;

namespace Magva.Infra.Data.Repository
{
    public class CustomerRepository : ICustomerRespository
    {
        public Customer Add(Customer obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public Customer Update(Customer obj)
        {
            throw new NotImplementedException();
        }
    }
}
