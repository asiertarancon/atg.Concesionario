using atg.Concesionario.Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atg.Concesionario.Domain.Vehicles
{
    public class Vehicle : Entity
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Horsepower { get; set; }
    }
}
