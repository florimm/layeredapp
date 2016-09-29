using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Domain.Server.Business.Messaging
{
    public class UserRequest
    {
        public UserRequest()
        {
            this.UserToken = "";
        }

        public string UserToken { get; set; }
    }
}
