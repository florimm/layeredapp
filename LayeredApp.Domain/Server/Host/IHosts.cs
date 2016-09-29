using LayeredApp.Domain.Server.Host.Hosts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Domain.Server.Host
{
    public interface IHosts
    {
        IContactHost GetContactHost();
    }
}
