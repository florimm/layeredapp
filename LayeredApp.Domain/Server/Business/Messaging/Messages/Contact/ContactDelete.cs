using LayeredApp.Domain.Server.Business.Messaging.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Domain.Server.Business.Messaging.Messages.Contact
{
    public class ContactDelete : Request
    {
        public ContactDelete()
        {
            this.ContactModelCollection = new List<ContactModel>();
        }

        public List<ContactModel> ContactModelCollection { get; set; }
    }

    public class ContactDeleteResponse : Response
    {
        public ContactDeleteResponse()
        {
            this.ContactModelCollection = new List<ContactModel>();
        }

        public List<ContactModel> ContactModelCollection { get; set; }
    }
}
