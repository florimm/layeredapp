using LayeredApp.Domain.Server.Business.Messaging.Messages.Contact;
using LayeredApp.Domain.Server.Host;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LayeredApp.Server.WebApi.Controllers
{
    [Route("api/[controller]")]
    public class ContactController : Controller
    {
        private IHostLayer _hostLayer = null;

        public ContactController(IHostLayer hostLayer)
        {
            _hostLayer = hostLayer;
        }

        [HttpPost]
        [ActionName("create")]
        public IActionResult Create([FromBody] ContactCreate request)
        {
            var response = _hostLayer.GetContactHost().Create(request);
            return new ObjectResult(response);
        }

        [HttpPost]
        [ActionName("update")]
        public IActionResult Update([FromBody] ContactUpdate request)
        {
            var response = _hostLayer.GetContactHost().Update(request);
            return new ObjectResult(response);
        }

        [HttpPost]
        [ActionName("delete")]
        public IActionResult Delete([FromBody] ContactDelete request)
        {
            var response = _hostLayer.GetContactHost().Delete(request);
            return new ObjectResult(response);
        }

        [HttpGet]
        [ActionName("getbymodel")]
        public ActionResult GetByModel([FromQuery] ContactGetByModel request)
        {
            var response = _hostLayer.GetContactHost().GetByModel(request);
            return new ObjectResult(response);
        }
    }
}
