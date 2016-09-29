using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Domain.Server.Business.Messaging
{
    public class Model
    {
        public Model()
        {
            this.Id = -1;
            this.CreatedBy = "";
            this.UpdatedBy = "";
            this.CreatedOn = "";
            this.UpdatedOn = "";
            this.Deleted = false;
            this.Reference = "";
        }

        public long Id { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public string CreatedOn { get; set; }
        public string UpdatedOn { get; set; }
        public bool Deleted { get; set; }
        public string Reference { get; set; }
    }
}
