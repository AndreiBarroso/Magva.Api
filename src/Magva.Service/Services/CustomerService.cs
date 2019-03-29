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
            _repository.Remove(id);
        }

        public IEnumerable<CustomerDto> GetAllCustomers()
        {
            return _repository.GetAll();
        }

        public CustomerDto GetCustomerById(Guid id)
        {
            return GetCustomerById(id);
        }

        public CustomerDto Register(CustomerDto customerDto)
        {
            return _repository.Add(customerDto);
        }

        public CustomerDto Update(CustomerDto customer)
        {
            return _repository.Update(customer);
        }
    }
}
