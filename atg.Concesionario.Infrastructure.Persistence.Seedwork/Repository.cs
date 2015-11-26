using atg.Concesionario.Domain.Seedwork;
using atg.Concesionario.Infrastructure.Crosscutting;
using atg.Concesionario.Infrastructure.Persistence.Seedwork;
using atg.Concesionario.Infrastructure.Persistence.Seedwork.Resources;
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

        public virtual void Add(TEntity aggregate)
        {
            throw new NotImplementedException();
        }

        public virtual void Modify(TEntity aggregate)
        {
            throw new NotImplementedException();
        }

        public virtual void Delete(TEntity aggregate)
        {
            throw new NotImplementedException();
        }

        public virtual IList<TEntity> FindById(int id)
        {
            throw new NotImplementedException();
        }

        public virtual IList<TEntity> FindAll()
        {
            throw new NotImplementedException();
        }

    }
}
