using atg.Concesionario.Domain.Seedwork;
using atg.Concesionario.Infrastructure.Persistence.Seedwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atg.Concesionario.Persistence.Seedwork
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : Entity
    {
        public Repository(IAdoNetUnitOfWork unitOfWork)
        {
            if (unitOfWork == (IAdoNetUnitOfWork)null)
                throw new ArgumentNullException("unitOfWork");
            _UnitOfWork = unitOfWork;
        }

        IAdoNetUnitOfWork _UnitOfWork;        
        public IUnitOfWork UnitOfWork
        {
            get
            {
                return _UnitOfWork;
            }
        }

        public bool Add(TEntity aggregate)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TEntity aggregate)
        {
            throw new NotImplementedException();
        }

        public IList<TEntity> FindAll()
        {
            throw new NotImplementedException();
        }

        public bool Save(TEntity aggregate)
        {
            throw new NotImplementedException();
        }
    }
}
