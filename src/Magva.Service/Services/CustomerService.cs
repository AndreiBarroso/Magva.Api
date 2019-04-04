using Magva.Infra.Crosscutting.DataTransferObject;
using Magva.Domain.Entities;
using Magva.Domain.Interfaces.Repository;
using Magva.Domain.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using Magva.Domain.Shared.ValueObject;

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
                Phone = customerDto.Phone,
                Document = new Document(customerDto.Document),
                Email = new Email(customerDto.Email),
                Id = customerDto.Id,
                Name = new Name(customerDto.FirstName, customerDto.LastName)
              

            };
        }

        private CustomerDto HydrateCustomerDto(Customer customer)
        {
            return new CustomerDto
            {
                FirstName  = customer.Name.FirstName,
                LastName = customer.Name.LastName,
                Document = customer.Document.ToString(),
                Email = customer.Document.ToString(),
                Phone = customer.Phone

            };
        }
    }
}
