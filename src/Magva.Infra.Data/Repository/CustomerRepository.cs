using Magva.Domain.Interfaces.Repository;
using Magva.Infra.Data.DataContext;
using Magva.Domain.Entities;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Magva.Infra.Data.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {

        private readonly MagvaDataContext _context;

        public CustomerRepository(MagvaDataContext context) : base(context)
        {
            _context = context;
        }

        public Customer GetCustomerByDocument(string document)
        {
            return _context.Customers
                 .Where(x => x.Document == document)
                 .AsNoTracking()
                 .FirstOrDefault();
        }
    }
}
