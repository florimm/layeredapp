using LayeredApp.Domain.Server.Core.Database.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Domain.Server.Core.Database
{
    public interface IRepositories
    {
        IContactRepository GetContactRepository();
    }
}
