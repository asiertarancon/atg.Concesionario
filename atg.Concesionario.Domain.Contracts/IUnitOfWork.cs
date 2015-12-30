using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atg.Concesionario.Domain.Contracts
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();
        void RollbackChanges();        
    }
}
