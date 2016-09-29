using LayeredApp.Domain.Server.Business.Messaging.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Domain.Server.Business.Messaging.Messages.Contact
{
    public class ContactGetByModel : Request
    {
        public ContactGetByModel()
        {
            this.ContactModel = new ContactModel();
        }

        public ContactModel ContactModel { get; set; }
    }

    public class ContactGetByModelResponse : Response
    {
        public ContactGetByModelResponse()
        {
            this.ContactModelCollection = new List<ContactModel>();
        }

        public List<ContactModel> ContactModelCollection { get; set; }
    }
}
