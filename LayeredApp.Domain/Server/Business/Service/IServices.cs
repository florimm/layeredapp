using LayeredApp.Domain.Server.Business.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Domain.Server.Business.Service
{
    public interface IServices
    {
        IContactService GetContactService();
    }
}
