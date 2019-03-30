using Magba.Infra.Crosscutting.DataTransferObject;
using System;

namespace Magva.Domain.Interfaces.Repository
{
    public interface ICustomerRepository : IRepository<CustomerDto>
    {
        CustomerDto BalanceCustomer(Guid id);
    }
}
