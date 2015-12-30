using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atg.Concesionario.Domain.Customers
{
    public class Customer : Entity<int>
    {        
        public string Name { get; set; }
        public string Surnames { get; set; }
        public string Telephone { get; set; }
        public bool Vip { get; set; }

    }
}
