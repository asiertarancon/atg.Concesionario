using atg.Concesionario.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atg.Concesionario.Domain.Orders;
using atg.Concesionario.Persistence.Seedwork;
using atg.Concesionario.Persistence.UnitOfWork;

namespace atg.Concesionario.Persistence.Repositories
{
    public class BudgetRepository : Repository<Budget>, IBudgetRepository
    {
        /// <summary>
        /// Create a new instance
        /// </summary>
        /// <param name="unitOfWork">Associated unit of work</param>
        public BudgetRepository(AdoNetUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
    }
}
