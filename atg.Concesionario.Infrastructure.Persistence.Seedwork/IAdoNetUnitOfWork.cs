using atg.Concesionario.Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atg.Concesionario.Infrastructure.Persistence.Seedwork
{
    public interface IAdoNetUnitOfWork : IUnitOfWork
    {
        IDbConnection Connection { get; }
        
        IDbTransaction Transaction { get; }

        IDbCommand CreateCommand();
    }
}
