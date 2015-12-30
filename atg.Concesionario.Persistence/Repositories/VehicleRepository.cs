using atg.Concesionario.Domain.Contracts.Repositories;
using atg.Concesionario.Domain.Vehicles;

namespace atg.Concesionario.Persistence.Repositories
{
    public class VehicleRepository : GenericRepository<Vehicle>, IVehicleRepository
    {
        /// <summary>
        /// Create a new instance
        /// </summary>
        /// <param name="context">Associated context</param>
        public VehicleRepository(AuthorizedDealerDBContext context)
            : base(context)
        {

        }
    }
}
