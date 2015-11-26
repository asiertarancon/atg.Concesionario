using atg.Concesionario.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atg.Concesionario.Domain.Orders;
using atg.Concesionario.Persistence.Seedwork;
using atg.Concesionario.Persistence.UnitOfWork;
using System.Data.SqlClient;
using System.Data;

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

        public override void Add(Budget budget)
        {
            //Insert budget in BD
            using (var cmd = (UnitOfWork as AdoNetUnitOfWork).CreateCommand())
            {
                var command = cmd as SqlCommand;
                command.CommandText = "INSERT INTO Budget (Estado, Importe, ClienteId, VehicleId) VALUES (@Estado, @Importe, @ClienteId, @VehicleId);select @@IDENTITY";
                //command.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = id });
                command.Parameters.Add(new SqlParameter("@Estado", SqlDbType.NVarChar) { Value = budget.State });
                command.Parameters.Add(new SqlParameter("@Importe", SqlDbType.Float) { Value = budget.Amount });
                command.Parameters.Add(new SqlParameter("@ClienteId", SqlDbType.Int) { Value = budget.Customer.Id });
                command.Parameters.Add(new SqlParameter("@VehicleId", SqlDbType.Int) { Value = budget.Vehicle.Id });

                command.ExecuteScalar();
            }            
        }

        public override void Modify(Budget budget)
        {
            
        }

        public override void Delete(Budget budget)
        {
            
        }

    }
}
