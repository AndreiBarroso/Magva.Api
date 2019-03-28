using Magva.Domain.Entities;
using System;

namespace Magva.Domain.Interfaces.Service
{
    public interface ICustomerService
    {
        void Register(Customer customer);
        void Update(Customer customer);
        Customer GetCustomerById(Guid id);
        IEquatable<Customer> GetAllCustomers();
        void Delete(Guid id);
    }
}
