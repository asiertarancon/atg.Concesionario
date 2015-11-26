using atg.Concesionario.Domain.Customers;
using atg.Concesionario.Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atg.Concesionario.Domain.Repositories
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Customer FindById(string id);
    }
}
