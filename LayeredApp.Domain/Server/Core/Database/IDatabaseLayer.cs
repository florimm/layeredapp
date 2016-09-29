using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Domain.Server.Core.Database
{
    public interface IDatabaseLayer : IRepositories, IUnitOfWork, IDisposable
    {

    }
}
