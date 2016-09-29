using LayeredApp.Domain.Server.Business.Messaging.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Domain.Server.Business.Messaging.Messages.Contact
{
    public class ContactCreate : Request
    {
        public ContactCreate()
        {
            this.ContactModelCollection = new List<ContactModel>();
        }

        public List<ContactModel> ContactModelCollection { get; set; }
    }

    public class ContactCreateResponse : Response
    {
        public ContactCreateResponse()
        {
            this.ContactModelCollection = new List<ContactModel>();
        }

        public List<ContactModel> ContactModelCollection { get; set; }
    }
}
