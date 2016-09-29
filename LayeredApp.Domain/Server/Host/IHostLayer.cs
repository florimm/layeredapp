using LayeredApp.Domain.Server.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Domain.Server.Host
{
    public interface IHostLayer : IHosts, IDisposable
    {
        IBusinessLayer GetBusinessLayer();
    }
}
