using atg.Concesionario.Domain.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atg.Concesionario.Domain.Customers;
using atg.Concesionario.Persistence.UnitOfWork;
using System.Data.SqlClient;
using System.Data;
using AutoMapper;

namespace atg.Concesionario.Persistence.Repositories
{
    public class CustomerRepository : GenericRepository<Customer>, ICustomerRepository
    {
        /// <summary>
        /// Create a new instance
        /// </summary>
        /// <param name="context">Associated context</param>
        public CustomerRepository(AuthorizedDealerDBContext context)
            : base(context)
        {

        }

        public Customer FindById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
