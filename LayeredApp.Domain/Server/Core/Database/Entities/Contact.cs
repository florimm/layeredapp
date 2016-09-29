using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Domain.Server.Core.Database.Entities
{
    public class Contact : Entity
    {
        public Contact()
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
