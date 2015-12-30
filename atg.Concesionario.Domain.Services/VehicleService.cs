using atg.Concesionario.Application.Common;
using atg.Concesionario.Domain.Contracts;
using atg.Concesionario.Domain.Contracts.Repositories;
using atg.Concesionario.Domain.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atg.Concesionario.Domain.Services
{
    public class VehicleService : EntityService<Vehicle>, IVehicleService
    {
        IUnitOfWork _unitOfWork;
        IVehicleRepository _vehicleRepository;

        public VehicleService(IUnitOfWork unitOfWork, IVehicleRepository vehicleRepository)
            : base(unitOfWork, vehicleRepository)
        {
            _unitOfWork = unitOfWork;
            _vehicleRepository = vehicleRepository;
        }

        public Vehicle GetById(int Id)
        {
            throw new NotImplementedException();
        }        
    }
}
