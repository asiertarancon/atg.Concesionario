using atg.Concesionario.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using atg.Concesionario.Domain.Customers;
using atg.Concesionario.Persistence.Seedwork;
using atg.Concesionario.Persistence.UnitOfWork;
using System.Data.SqlClient;
using System.Data;
using AutoMapper;

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

        public Customer FindById(int id)
        {
            using (var cmd = (UnitOfWork as AdoNetUnitOfWork).CreateCommand())
            {
                var command = cmd as SqlCommand;
                command.CommandText = "SELECT * FROM Vehicles WHERE Id = @id";
                command.Parameters.Add(new SqlParameter("@Id", SqlDbType.Int) { Value = id });

                using (var reader = command.ExecuteReader())
                    if (reader.HasRows)
                        return Mapper.DynamicMap<IDataReader, Customer>(reader);

            }
            return null;
        }
    }
}
