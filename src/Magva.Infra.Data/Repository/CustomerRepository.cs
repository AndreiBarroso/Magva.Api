using Magva.Domain.Interfaces.Repository;
using Magva.Infra.Data.DataContext;
using Magva.Domain.Entities;

namespace Magva.Infra.Data.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {

        public CustomerRepository(MagvaDataContext context) : base(context)
        {
    
        }
    }
}
