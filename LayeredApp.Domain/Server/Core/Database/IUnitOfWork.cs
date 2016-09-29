using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Domain.Server.Core.Database
{
    public interface IUnitOfWork
    {
        int ExecuteSqlCommand(string sql);
        void BeginTransaction();
        void Commit();
        void Rollback();
        void SaveChanges();
    }
}
