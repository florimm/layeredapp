using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Domain.Server.Business.Validation
{
    public class ValidationResult
    {
        public ValidationResult()
        {
            this.IsValid = false;
            this.Errors = new List<string>();
        }

        public bool IsValid { get; set; }
        public List<string> Errors { get; set; }
    }
}
