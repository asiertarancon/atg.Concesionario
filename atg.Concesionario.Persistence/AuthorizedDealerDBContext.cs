using atg.Concesionario.Domain.Customers;
using atg.Concesionario.Domain.Budgets;
using atg.Concesionario.Domain.Vehicles;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atg.Concesionario.Persistence
{
    public class AuthorizedDealerDBContext : DbContext
    {
        public AuthorizedDealerDBContext() : base("ConcesionarioAsier")
        {

        }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Customer> Customers { get; set; } 
        public DbSet<Budget> Budgets { get; set; }
    }

}
