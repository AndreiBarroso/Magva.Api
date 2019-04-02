using Magva.Infra.Crosscutting.DataTransferObject;
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
            var customer = new CustomerDto
            {
                Phone = obj.Phone,
                Balance = obj.Balance,
                Name = obj.Name,
                Email = obj.Email,
                Document = obj.Document

            };
            _context.Entry<CustomerDto>(customer)
                .State = EntityState.Added;
            _context.SaveChanges();

            return customer;
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
                   Name = x.Name.ToString(),
                   Email = x.Email.ToString(),
                   Document = x.Document.ToString()

               })
               .AsNoTracking()
               .ToList();
        }

        public CustomerDto GetById(Guid id)
        {
            return _context
              .Customers
              .Select(x => new CustomerDto
              {
                  BirthDate = x.BirthDate,
                  Id = x.Id,
                  Phone = x.Phone,
                  Balance = x.Balance,
                  Name = x.Name.ToString(),
                  Email = x.Email.ToString(),
                  Document = x.Document.ToString()
              })
               .AsNoTracking()
               .Where(x => x.Id == id)
               .FirstOrDefault();
        }

        public void Remove(Guid id)
        {
            var customer = GetById(id);

            _context.Remove(customer);
            _context.SaveChanges();
        }

        public CustomerDto Update(CustomerDto obj)
        {
            var customer = new CustomerDto
            {

                Phone = obj.Phone,
                Balance = obj.Balance,
                Name = obj.Name.ToString(),
                Email = obj.Email.ToString(),
                Document = obj.Document.ToString()

            };
            _context.Entry<CustomerDto>(customer)
                .State = EntityState.Modified;
            _context.SaveChanges();

            return customer;
        }
    }
}
