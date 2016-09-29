using LayeredApp.Domain.Server.Core.Database;
using LayeredApp.Domain.Server.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Domain.Server.Core
{
    public interface ICoreLayer : IDisposable
    {
        IDatabaseLayer GetDatabaseLayer();
        IUtilitiesLayer GetUtilitiesLayer();
    }
}
