using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atg.Concesionario.Domain.Seedwork
{
    public interface IRepository<TAggregate>
    {
        /// <summary>
        /// Get the unit of work in this repository
        /// </summary>
        IUnitOfWork UnitOfWork { get; }

        IList<TAggregate> FindAll();
       
        void Add(TAggregate aggregate);
        
        void Modify(TAggregate aggregate);

        void Delete(TAggregate aggregate);
    }
}
