using Magba.Infra.Crosscutting.DataTransferObject;
using Magva.Domain.Interfaces.Repository;
using Magva.Infra.Data.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Magva.Infra.Data.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly MagvaDataContext _context;

        public CustomerRepository(MagvaDataContext context)
        {
            _context = context;
        }

        public CustomerDto Add(CustomerDto obj)
        {
            throw new NotImplementedException();
        }

        public CustomerDto BalanceCustomer(Guid id)
        {
            return _context
             .Customers
             .Select(x => new CustomerDto
             {
                 Balance = x.Balance,
             })
              .AsNoTracking()
              .Where(x => x.Id == id)
              .FirstOrDefault();
        }

        public IEnumerable<CustomerDto> GetAll()
        {
            return _context
               .Customers
               .Select(x => new CustomerDto
               {
                   BirthDate = x.BirthDate,
                   Id = x.Id,
                   Phone = x.Phone,
                   Balance = x.Balance,
                   AddressId = x.Address.Id
               })
               .AsNoTracking()
               .ToList();
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
