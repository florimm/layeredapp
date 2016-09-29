using LayeredApp.Domain.Server.Core.Database.Entities;
using LayeredApp.Domain.Server.Core.Database.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Server.Core.Database.Repositories
{
    public class ContactRepository : Repository<Contact>, IContactRepository
    {
        public ContactRepository(LayeredAppDbContext dbContext)
            : base(dbContext)
        {

        }
    }
}
