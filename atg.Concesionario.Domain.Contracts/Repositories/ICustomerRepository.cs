using atg.Concesionario.Domain.Customers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atg.Concesionario.Domain.Contracts.Repositories
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        Customer FindById(int id);
    }
}
