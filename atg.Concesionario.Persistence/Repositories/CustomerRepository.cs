using atg.Concesionario.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atg.Concesionario.Domain.Customers;
using atg.Concesionario.Persistence.Seedwork;
using atg.Concesionario.Persistence.UnitOfWork;

namespace atg.Concesionario.Persistence.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        /// <summary>
        /// Create a new instance
        /// </summary>
        /// <param name="unitOfWork">Associated unit of work</param>
        public CustomerRepository(AdoNetUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }

        public Customer FindById(string id)
        {
            throw new NotImplementedException();
        }
    }
}
