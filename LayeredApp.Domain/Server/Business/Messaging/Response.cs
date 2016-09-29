using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Domain.Server.Business.Messaging
{
    public class Response
    {
        public Response()
        {
            this.ResponseStatus = new ResponseStatus();
        }

        public ResponseStatus ResponseStatus { get; set; }
    }
}
