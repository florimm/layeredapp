using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Domain.Server.Business.Messaging
{
    public class Request
    {
        public Request()
        {
            this.Token = "";
            this.UniqueValue = "";
            this.Signature = "";
        }

        public string Token { get; set; }
        public string UniqueValue { get; set; }
        public string Signature { get; set; }
    }
}
