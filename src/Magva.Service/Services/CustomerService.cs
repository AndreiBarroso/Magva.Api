using Magva.Infra.Crosscutting.DataTransferObject;
using Magva.Domain.Entities;
using Magva.Domain.Interfaces.Repository;
using Magva.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Magva.Service.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public void Delete(Guid id)
        {
            _repository.Remove(id);
        }

        public IEnumerable<CustomerDto> GetAllCustomers()
        {
            var customers = _repository.GetAll().Select(x => HydrateCustomerDto(x));
            return customers.ToList();
        }

        public CustomerDto GetCustomerById(Guid id)
        {
            var customer = _repository.GetById(id);
            return HydrateCustomerDto(customer);
        }

        public CustomerDto Register(CustomerDto customerDto)
        {
            var customer = HydrateCustomer(customerDto);

            _repository.Add(customer);

            return HydrateCustomerDto(customer);
        }

        public CustomerDto Update(CustomerDto customerDto)
        {
            var customer = HydrateCustomer(customerDto);
            _repository.Add(customer);

            return HydrateCustomerDto(customer);
        }

        private Customer HydrateCustomer(CustomerDto customerDto)
        {
            return new Customer
            {
                Id = customerDto.Id,
                Phone = customerDto.Phone,
                Document = customerDto.Document,
                Email = customerDto.Email,
                Name = customerDto.Name
            };
        }

        private CustomerDto HydrateCustomerDto(Customer customer)
        {
            return new CustomerDto
            {
                Id = customer.Id,
                Name = customer.Name,
                Document = customer.Document,
                Email = customer.Document,
                Phone = customer.Phone
            };
        }
    }
}
