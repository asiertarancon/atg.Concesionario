using atg.Concesionario.Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atg.Concesionario.Persistence.UnitOfWork
{
    public class AdoNetUnitOfWork : IUnitOfWork
    {
        IDbConnection _connection;
        bool _ownsConnection;
        IDbTransaction _transaction;

        public AdoNetUnitOfWork(IDbConnection connection, bool ownsConnection)
        {
            _connection = connection;
            _ownsConnection = ownsConnection;
            _transaction = connection.BeginTransaction();
        }

        public void SaveChanges()
        {
            if (_transaction == null)
                throw new InvalidOperationException("Transaction have already been commited. Check your transaction handling.");

            _transaction.Commit();
            _transaction = null;
        }

        public void SaveAndRefreshChanges()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            RollbackChanges();

            if (_connection != null && _ownsConnection)
            {
                _connection.Close();
                _connection = null;
            }
        }

        public void RollbackChanges()
        {
            if (_transaction != null)
            {
                _transaction.Rollback();
                _transaction = null;
            }
        }        

        public IDbCommand CreateCommand()
        {
            var command = _connection.CreateCommand();
            command.Transaction = _transaction;
            return command;
        }
    }
}
