using LayeredApp.Domain.Server.Core.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LayeredApp.Domain.Server.Core.Database.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using LayeredApp.Server.Core.Database.Repositories;

namespace LayeredApp.Server.Core.Database
{
    public class DatabaseLayer : IDatabaseLayer
    {
        private LayeredAppDbContext _dbContext = null;
        private IDbContextTransaction _dbContextTransaction = null;

        private IContactRepository _contactRepository = null;

        public DatabaseLayer(string connectionString)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LayeredAppDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            _dbContext = new LayeredAppDbContext(optionsBuilder.Options);
        }

        public IContactRepository GetContactRepository()
        {
            if (_contactRepository == null)
                _contactRepository = new ContactRepository(_dbContext);
            return _contactRepository;
        }

        public void BeginTransaction()
        {
            _dbContextTransaction = _dbContext.Database.BeginTransaction();
        }

        public void Commit()
        {
            try
            {
                _dbContext.SaveChanges();
                if (_dbContextTransaction != null)
                    _dbContextTransaction.Commit();
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                if (_dbContextTransaction != null)
                {
                    _dbContextTransaction.Dispose();
                    _dbContextTransaction = null;
                }
            }
        }

        public int ExecuteSqlCommand(string sql)
        {
            return _dbContext.Database.ExecuteSqlCommand(sql);
        }

        public void Rollback()
        {
            try
            {
                if (_dbContextTransaction != null)
                    _dbContextTransaction.Rollback();
            }
            catch (Exception exception)
            {
                throw exception;
            }
            finally
            {
                if (_dbContextTransaction != null)
                {
                    _dbContextTransaction.Dispose();
                    _dbContextTransaction = null;
                }
            }
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if(disposing)
            {
                _contactRepository = null;

                if(_dbContext != null)
                {
                    _dbContext.Dispose();
                    _dbContext = null;
                }
            }
        }
    }
}
