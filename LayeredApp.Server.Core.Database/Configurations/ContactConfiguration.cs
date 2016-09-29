using LayeredApp.Domain.Server.Core.Database.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Server.Core.Database.Configurations
{
    public class ContactConfiguration
    {
        public ContactConfiguration(EntityTypeBuilder<Contact> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(x => x.Id);
        }
    }
}
