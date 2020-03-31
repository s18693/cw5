using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using cw3.Services;


namespace cw3.Controllers
{
    [Route("api")]
    [ApiController]
    public class EnrollmentsController : ControllerBase
    {
        private readonly IStudentsDbService dbService;

        public EnrollmentsController(IStudentsDbService ISDS)
        {
            dbService = ISDS;
        }

        [HttpGet]
        public IActionResult GetStudent()
        {
            return Ok(dbService.GetStudents());
        }


        // GET: api/Enrollments
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Enrollments/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Enrollments
        [HttpPost("enrollments")]
        public void Post(string INumber, string FName, string LName, string BDate, string Studies)
        {
            dbService.AddStudnet(INumber, FName, LName, BDate, Studies);
            return Created("",);
        }

        // PUT: api/Enrollments/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
