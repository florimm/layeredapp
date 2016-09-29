using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Domain.Server.Business.Messaging
{
    public class ResponseStatus
    {
        public ResponseStatus()
        {
            this.Success = false;
            this.Code = -1;
            this.Message = "";
            this.Explanation = "";
            this.Details = new List<string>();
        }

        public bool Success { get; set; }
        public int Code { get; set; }
        public string Message { get; set; }
        public string Explanation { get; set; }
        public List<string> Details { get; set; }
    }
}
