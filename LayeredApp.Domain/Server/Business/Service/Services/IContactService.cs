using LayeredApp.Domain.Server.Business.Messaging.Messages.Contact;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Domain.Server.Business.Service.Services
{
    public interface IContactService
    {
        ContactCreateResponse Create(ContactCreate request);
        ContactUpdateResponse Update(ContactUpdate request);
        ContactDeleteResponse Delete(ContactDelete request);
        ContactGetByModelResponse GetByModel(ContactGetByModel request);
    }
}
