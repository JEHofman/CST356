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
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Employees>> Get()
        {
            return getEmployees();
        }

        private List<Employees> getEmployees()
        {
            return InMemory.employees;
        }   

        // // GET api/values/5
        // [HttpGet("{id}")]
        // public ActionResult<string> Get(int id)
        // {
        //     return "value";
        // }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Employees employees)
        {
            employees.First = getNextFirst();
            employees.Last = getNextLast();

            InMemory.employees.Add(employees);
        }

        private string getNextFirst()
        {
            return InMemory.employees.Max(p => p.First) + 1;
        }
          private string getNextLast()
        {
            return InMemory.employees.Max(p => p.Last) + 1;
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