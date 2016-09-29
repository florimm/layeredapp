using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Domain.Server.Business.Messaging.Models
{
    public class ContactModel : Model
    {
        public ContactModel()
        {
            this.FirstName = "";
            this.LastName = "";
            this.Email = "";
            this.Number = "";
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
    }
}
