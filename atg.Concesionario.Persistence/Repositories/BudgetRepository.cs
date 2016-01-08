using atg.Concesionario.Domain.Contracts.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atg.Concesionario.Domain.Budgets;
using atg.Concesionario.Persistence.UnitOfWork;
using System.Data.SqlClient;
using System.Data;
using System.Data.Entity;

namespace atg.Concesionario.Persistence.Repositories
{
    public class BudgetRepository : GenericRepository<Budget>, IBudgetRepository
    {
        /// <summary>
        /// Create a new instance
        /// </summary>
        /// <param name="context">Associated context</param>
        public BudgetRepository(DbContext dbContext) : base(dbContext)
        {

        }
       

    }
}
