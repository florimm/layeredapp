using LayeredApp.Domain.Server.Business.Validation.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Domain.Server.Business.Validation
{
    public interface IValidators
    {
        IContactValidator GetContactValidator();
    }
}
