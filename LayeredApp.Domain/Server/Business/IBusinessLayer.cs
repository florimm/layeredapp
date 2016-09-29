using LayeredApp.Domain.Server.Business.Service;
using LayeredApp.Domain.Server.Business.Validation;
using LayeredApp.Domain.Server.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Domain.Server.Business
{
    public interface IBusinessLayer : IDisposable
    {
        ICoreLayer GetCoreLayer();
        IServiceLayer GetServiceLayer();
        IValidationLayer GetValidationLayer();
    }
}
