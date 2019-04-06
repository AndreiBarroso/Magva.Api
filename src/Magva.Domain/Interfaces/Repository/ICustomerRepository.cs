using Magva.Domain.Entities;
using Magva.Infra.Crosscutting.DataTransferObject;
using System;

namespace Magva.Domain.Interfaces.Repository
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Customer GetCustomerByDocument(string document);
    }
}
