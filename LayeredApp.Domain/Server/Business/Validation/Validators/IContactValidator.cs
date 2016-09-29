using LayeredApp.Domain.Server.Business.Messaging.Messages.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Domain.Server.Business.Validation.Validators
{
    public interface IContactValidator
    {
        ValidationResult Create(ContactCreate request);
        ValidationResult Update(ContactUpdate request);
        ValidationResult Delete(ContactDelete request);
        ValidationResult GetByModel(ContactGetByModel request);
    }
}
