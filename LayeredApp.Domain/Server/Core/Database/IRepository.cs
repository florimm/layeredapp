using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Domain.Server.Core.Database
{
    public interface IRepository<T> where T : Entity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(object id);
        IEnumerable<T> GetAll();
    }
}
