using LayeredApp.Domain.Server.Business.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LayeredApp.Domain.Server.Business.Validation.Validators;
using LayeredApp.Domain.Server.Core;
using LayeredApp.Server.Business.Validation.Validators;

namespace LayeredApp.Server.Business.Validation
{
    public class ValidationLayer : IValidationLayer
    {
        private ICoreLayer _coreLayer = null;
        private IContactValidator _contactValidator = null;

        public ValidationLayer(ICoreLayer coreLayer)
        {
            _coreLayer = coreLayer;
        }

        public IContactValidator GetContactValidator()
        {
            if (_contactValidator == null)
                _contactValidator = new ContactValidator(_coreLayer);
            return _contactValidator;
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

                _contactValidator = null;
            }
        }
    }
}
