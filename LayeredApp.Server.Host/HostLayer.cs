using LayeredApp.Domain.Server.Host;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LayeredApp.Domain.Server.Business;
using LayeredApp.Domain.Server.Host.Hosts;
using LayeredApp.Server.Host.Hosts;

namespace LayeredApp.Server.Host
{
    public class HostLayer : IHostLayer
    {
        private IBusinessLayer _businessLayer = null;
        private IContactHost _contactHost = null;

        public HostLayer(IBusinessLayer businessLayer)
        {
            _businessLayer = businessLayer;
        }

        public IBusinessLayer GetBusinessLayer()
        {
            return _businessLayer;
        }

        public IContactHost GetContactHost()
        {
            if (_contactHost == null)
                _contactHost = new ContactHost(_businessLayer);
            return _contactHost;
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
                //if(_businessLayer != null)
                //{
                //    _businessLayer.Dispose();
                //    _businessLayer = null;
                //}

                _contactHost = null;
            }
        }
    }
}
