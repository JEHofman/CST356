using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;
using Database.Entities;
using Database;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicesController : ControllerBase
    {
        private readonly IServicesService _servicesService;

        public ServicesController(IServicesService servicesService)
        {
            _servicesService = servicesService;
            
        }

       [HttpGet]
        public ActionResult<List<ServicesDto>> GetAllServices()
        {

            return _servicesService.GetAllServices();
        }

        private List<Services> getServices()
        {
            return InMemory.services;
        }   

        // // GET api/values/5
        // [HttpGet("{id}")]
        // public ActionResult<string> Get(int id)
        // {
        //     return "value";
        // }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Services services)
        {
            services.Item = getNextItem();
            services.Type = getNextType();
            InMemory.services.Add(services);
        }

        private string getNextItem()
        {
            return InMemory.services.Max(p => p.Item) + 1;
        }
        private string getNextType()
        {
            return InMemory.services.Max(p => p.Type) + 1;
        }

        // // PUT api/values/5
        // [HttpPut("{id}")]
        // public void Put(int id, [FromBody] string value)
        // {
        // }

        // // DELETE api/values/5
        // [HttpDelete("{id}")]
        // public void Delete(int id)
        // {
        // }
    }
}