using Magba.Infra.Crosscutting.DataTransferObject;
using Magva.Domain.Entities;
using Magva.Domain.Interfaces.Repository;
using Magva.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;

namespace Magva.Service.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRespository _repository;

        public CustomerService(ICustomerRespository repository)
        {
            _repository = repository;
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomerDto> GetAllCustomers()
        {
            throw new NotImplementedException();
        }

        public CustomerDto GetCustomerById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Customer Register(Customer customer)
        {
            throw new NotImplementedException();
        }

        public CustomerDto Update(CustomerDto customer)
        {
            throw new NotImplementedException();
        }
    }
}
