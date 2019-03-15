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
    public class PersonsController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Persons>> Get()
        {
            return getPersons();
        }

        private List<Persons> getPersons()
        {
            return InMemory.persons;
        }   

        // // GET api/values/5
        // [HttpGet("{id}")]
        // public ActionResult<string> Get(int id)
        // {
        //     return "value";
        // }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Persons persons)
        {
            persons.First = getNextFirst();
            persons.MiddleI = getNextMiddle();
            persons.Last = getNextLast();

            InMemory.persons.Add(persons);
        }

        private string getNextFirst()
        {
            return InMemory.persons.Max(p => p.First) + 1;
        }
          private string getNextMiddle()
        {
            return InMemory.persons.Max(p => p.MiddleI) + 1;
        }
          private string getNextLast()
        {
            return InMemory.persons.Max(p => p.Last) + 1;
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