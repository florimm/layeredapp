using LayeredApp.Domain.Server.Business.Messaging.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Domain.Server.Business.Messaging.Messages.Contact
{
    public class ContactUpdate : Request
    {
        public ContactUpdate()
        {
            this.ContactModel = new List<Models.ContactModel>();
        }

        public List<ContactModel> ContactModel { get; set; }
    }

    public class ContactUpdateResponse : Response
    {
        public ContactUpdateResponse()
        {
            this.ContactModel = new List<Models.ContactModel>();
        }

        public List<ContactModel> ContactModel { get; set; }
    }
}
