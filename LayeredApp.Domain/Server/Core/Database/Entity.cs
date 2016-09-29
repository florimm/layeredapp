using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Domain.Server.Core.Database
{
    public class Entity
    {
        public Entity()
        {
            this.Id = -1;
            this.CreatedBy = "";
            this.UpdatedBy = "";
            this.CreatedOn = DateTime.Now;
            this.UpdatedOn = DateTime.Now;
            this.Deleted = false;
            this.Reference = "";
        }

        public long Id { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public bool Deleted { get; set; }
        public string Reference { get; set; }
    }
}
