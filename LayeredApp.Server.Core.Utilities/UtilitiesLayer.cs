using LayeredApp.Domain.Server.Core.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Server.Core.Utilities
{
    public class UtilitiesLayer : IUtilitiesLayer
    {
        private ICryptographyUtility _cryptographyUtility = null;

        public UtilitiesLayer()
        {

        }

        public ICryptographyUtility GetCryptographyUtility()
        {
            if (_cryptographyUtility == null)
                _cryptographyUtility = new CryptographyUtility();
            return _cryptographyUtility;
        }

        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if(disposing)
            {
                _cryptographyUtility = null;
            }
        }
    }
}
