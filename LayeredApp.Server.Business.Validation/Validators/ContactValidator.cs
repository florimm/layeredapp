using LayeredApp.Domain.Server.Business.Validation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LayeredApp.Domain.Server.Business.Messaging.Messages.Contact;
using LayeredApp.Domain.Server.Business.Validation;
using LayeredApp.Domain.Server.Core;

namespace LayeredApp.Server.Business.Validation.Validators
{
    public class ContactValidator : IContactValidator
    {
        private ICoreLayer _coreLayer = null;

        public ContactValidator(ICoreLayer coreLayer)
        {
            _coreLayer = coreLayer;
        }

        public ValidationResult Create(ContactCreate request)
        {
            return new ValidationResult() { IsValid = true };
        }

        public ValidationResult Delete(ContactDelete request)
        {
            return new ValidationResult() { IsValid = true };
        }

        public ValidationResult GetByModel(ContactGetByModel request)
        {
            return new ValidationResult() { IsValid = true };
        }

        public ValidationResult Update(ContactUpdate request)
        {
            return new ValidationResult() { IsValid = true };
        }
    }
}
