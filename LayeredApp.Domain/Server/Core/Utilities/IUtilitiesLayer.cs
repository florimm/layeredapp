using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Domain.Server.Core.Utilities
{
    public interface IUtilitiesLayer : IDisposable
    {
        ICryptographyUtility GetCryptographyUtility();
    }
}
