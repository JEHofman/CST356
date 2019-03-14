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
    public class StudentsController : ControllerBase
    {
        private readonly IStudentsService _studentsService;

        public StudentsController(IStudentsService studentsService)
        {
            _studentsService = studentsService;
            
        }

       [HttpGet]
        [Authorize]
        public ActionResult<List<StudentsDto>> GetAllStudents()
        {

            return _studentsService.GetAllStudents();
        }

        private List<Students> getStudents()
        {
            return InMemory.students;
        }   

        // // GET api/values/5
        // [HttpGet("{id}")]
        // public ActionResult<string> Get(int id)
        // {
        //     return "value";
        // }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Students students)
        {
            students.StudentId = getNextId();
            students.Email = getNextEmail();
            InMemory.students.Add(students);
        }

        private long getNextId()
        {
            return InMemory.students.Max(p => p.StudentId) + 1;
        }
        private string getNextEmail()
        {
            return InMemory.students.Max(p => p.Email) + 1;
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