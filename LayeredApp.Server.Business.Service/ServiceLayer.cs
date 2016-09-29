using LayeredApp.Domain.Server.Business.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LayeredApp.Domain.Server.Business.Service.Services;
using LayeredApp.Domain.Server.Core;
using LayeredApp.Server.Business.Service.Services;

namespace LayeredApp.Server.Business.Service
{
    public class ServiceLayer : IServiceLayer
    {
        private ICoreLayer _coreLayer = null;
        private IContactService _contactService = null;

        public ServiceLayer(ICoreLayer coreLayer)
        {
            _coreLayer = coreLayer;
        }

        public IContactService GetContactService()
        {
            if (_contactService == null)
                _contactService = new ContactService(_coreLayer);
            return _contactService;
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
                //if(_coreLayer != null)
                //{
                //    _coreLayer.Dispose();
                //    _coreLayer = null;
                //}

                _contactService = null;
            }
        }
    }
}
