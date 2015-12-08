using atg.Concesionario.Domain.Customers;
using atg.Concesionario.Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atg.Concesionario.Domain.Contracts.Repositories
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Customer FindById(int id);
    }
}
