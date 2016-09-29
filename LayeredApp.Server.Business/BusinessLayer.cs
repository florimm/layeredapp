using LayeredApp.Domain.Server.Business;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LayeredApp.Domain.Server.Business.Service;
using LayeredApp.Domain.Server.Business.Validation;
using LayeredApp.Domain.Server.Core;

namespace LayeredApp.Server.Business
{
    public class BusinessLayer : IBusinessLayer
    {
        private ICoreLayer _coreLayer = null;
        private IServiceLayer _serviceLayer = null;
        private IValidationLayer _validationLayer = null;

        public BusinessLayer(ICoreLayer coreLayer, IServiceLayer serviceLayer,
            IValidationLayer validationLayer)
        {
            _coreLayer = coreLayer;
            _serviceLayer = serviceLayer;
            _validationLayer = validationLayer;
        }

        public ICoreLayer GetCoreLayer()
        {
            return _coreLayer;
        }

        public IServiceLayer GetServiceLayer()
        {
            return _serviceLayer;
        }

        public IValidationLayer GetValidationLayer()
        {
            return _validationLayer;
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

                //if(_serviceLayer != null)
                //{
                //    _serviceLayer.Dispose();
                //    _serviceLayer = null;
                //}

                //if(_validationLayer != null)
                //{
                //    _validationLayer.Dispose();
                //    _validationLayer = null;
                //}
            }
        }
    }
}
