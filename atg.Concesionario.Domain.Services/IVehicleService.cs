﻿using atg.Concesionario.Application.Common;
using atg.Concesionario.Domain.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atg.Concesionario.Domain.Services
{    
    public interface IVehicleService : IEntityService<Vehicle>
    {
        Vehicle GetById(int Id);
    }
}
