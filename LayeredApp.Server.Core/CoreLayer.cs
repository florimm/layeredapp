using LayeredApp.Domain.Server.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LayeredApp.Domain.Server.Core.Database;
using LayeredApp.Domain.Server.Core.Utilities;

namespace LayeredApp.Server.Core
{
    public class CoreLayer : ICoreLayer
    {
        private IDatabaseLayer _databaseLayer = null;
        private IUtilitiesLayer _utilitiesLayer = null;

        public CoreLayer(IDatabaseLayer databaseLayer, IUtilitiesLayer utilitiesLayer)
        {
            _databaseLayer = databaseLayer;
            _utilitiesLayer = utilitiesLayer;
        }

        public IDatabaseLayer GetDatabaseLayer()
        {
            return _databaseLayer;
        }

        public IUtilitiesLayer GetUtilitiesLayer()
        {
            return _utilitiesLayer;
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
                //if(_databaseLayer != null)
                //{
                //    _databaseLayer.Dispose();
                //    _databaseLayer = null;
                //}

                //if(_utilitiesLayer != null)
                //{
                //    _utilitiesLayer.Dispose();
                //    _utilitiesLayer = null;
                //}
            }
        }
    }
}
