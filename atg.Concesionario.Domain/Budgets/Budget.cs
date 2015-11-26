using atg.Concesionario.Domain.Customers;
using atg.Concesionario.Domain.Seedwork;
using atg.Concesionario.Domain.Vehicles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atg.Concesionario.Domain.Orders
{
    public class Budget : Entity
    {
        public string State { get; set; }
        public decimal Amount { get; set; }
        public Customer Customer { get; set; }
        public Vehicle Vehicle { get; set; }
    }
}
