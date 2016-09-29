using LayeredApp.Domain.Server.Host.Hosts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LayeredApp.Domain.Server.Business.Messaging.Messages.Contact;
using LayeredApp.Domain.Server.Business;

namespace LayeredApp.Server.Host.Hosts
{
    public class ContactHost : IContactHost
    {
        private IBusinessLayer _businessLayer = null;

        public ContactHost(IBusinessLayer businessLayer)
        {
            _businessLayer = businessLayer;
        }

        public ContactCreateResponse Create(ContactCreate request)
        {
            throw new NotImplementedException();
        }

        public ContactDeleteResponse Delete(ContactDelete request)
        {
            throw new NotImplementedException();
        }

        public ContactGetByModelResponse GetByModel(ContactGetByModel request)
        {
            return _businessLayer.GetServiceLayer().GetContactService().GetByModel(request);
        }

        public ContactUpdateResponse Update(ContactUpdate request)
        {
            throw new NotImplementedException();
        }
    }
}
