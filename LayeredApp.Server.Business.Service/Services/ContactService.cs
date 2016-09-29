using LayeredApp.Domain.Server.Business.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LayeredApp.Domain.Server.Business.Messaging.Messages.Contact;
using LayeredApp.Domain.Server.Core;

namespace LayeredApp.Server.Business.Service.Services
{
    public class ContactService : IContactService
    {
        private ICoreLayer _coreLayer = null;

        public ContactService(ICoreLayer coreLayer)
        {
            _coreLayer = coreLayer;
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
            var response = new ContactGetByModelResponse();
            response.ContactModelCollection = new List<Domain.Server.Business.Messaging.Models.ContactModel>();
            foreach (var item in _coreLayer.GetDatabaseLayer().GetContactRepository().GetAll().ToList())
            {
                response.ContactModelCollection.Add(new Domain.Server.Business.Messaging.Models.ContactModel()
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Email = item.Email,
                    Number = item.Number
                });
            }
            response.ResponseStatus = new Domain.Server.Business.Messaging.ResponseStatus()
            {
                Success = true,
                Code = 0,
                Message = "Ok",
                Explanation = "Ok",
                Details = { "Ok" }
            };
            return response;
        }

        public ContactUpdateResponse Update(ContactUpdate request)
        {
            throw new NotImplementedException();
        }
    }
}
