using LayeredApp.Domain.Server.Core.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Server.Core.Database
{
    public class Repository<T> : IRepository<T> where T : Entity
    {
        protected LayeredAppDbContext _dbContext = null;
        protected DbSet<T> _entities = null;

        public Repository(LayeredAppDbContext dbContext)
        {
            _dbContext = dbContext;
            _entities = _dbContext.Set<T>();
        }

        public void Create(T entity)
        {
            _entities.Add(entity);
        }

        public void Update(T entity)
        {
            EntityEntry entry = _dbContext.Entry(entity);
            if (entry.State == EntityState.Detached)
                _entities.Attach(entity);
            entry.State = EntityState.Modified;
        }

        public void Delete(T entity)
        {
            EntityEntry entry = _dbContext.Entry(entity);
            if (entry.State != EntityState.Deleted)
                entry.State = EntityState.Deleted;
            else
            {
                if (entry.State == EntityState.Detached)
                    _entities.Attach(entity);
                _entities.Remove(entity);
            }
        }

        public T GetById(object id)
        {
            return _entities.Single(x => x.Id == (long)id);
        }

        public IEnumerable<T> GetAll()
        {
            return _entities;
        }
    }
}
