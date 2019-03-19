using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Database;
using Database.Entities;

namespace webapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectssController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Projects>> Get()
        {
            return getProjects();
        }

        private List<Projects> getProjects()
        {
            return InMemory.projects;
        }   

        // // GET api/values/5
        // [HttpGet("{id}")]
        // public ActionResult<string> Get(int id)
        // {
        //     return "value";
        // }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Projects projects)
        {
            projects.Name = getNextName();
            projects.Address = getNextAddress();

            InMemory.projects.Add(projects);
        }

        private string getNextName()
        {
            return InMemory.projects.Max(p => p.Name) + 1;
        }
          private string getNextAddress()
        {
            return InMemory.projects.Max(p => p.Address) + 1;
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