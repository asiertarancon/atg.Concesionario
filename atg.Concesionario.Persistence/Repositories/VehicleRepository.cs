using atg.Concesionario.Domain.Repositories;
using atg.Concesionario.Domain.Vehicles;
using atg.Concesionario.Persistence.Seedwork;
using atg.Concesionario.Persistence.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atg.Concesionario.Persistence.Repositories
{
    public class VehicleRepository : Repository<Vehicle>, IVehicleRepository
    {
        /// <summary>
        /// Create a new instance
        /// </summary>
        /// <param name="unitOfWork">Associated unit of work</param>
        public VehicleRepository(AdoNetUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
    }
}
