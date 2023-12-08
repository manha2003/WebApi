using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;

namespace StudentWeb.Controllers.v1
{
    /*[ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/students")]*/

    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public List<Student> students = new List<Student>();
        public StudentsController()
        {
            students.Add(new Student(108, "Peter", "DHTH20A"));
            students.Add(new Student(109, "Jack", "DHTH20A"));
            students.Add(new Student(110, "Mark", "DHTH20A"));
        }

        // GET: api/<StudentsController>
        [HttpGet]
        public List<Student> Get()
        {
            return students;
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return students.FirstOrDefault(m => m.Id.Equals(id));
        }

        // POST api/<StudentsController>
        [HttpPost]
        public Student Post([FromBody] Student student)
        {
            students.Add(student);
            return student;
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Student student)
        {
            var oldStudent = students.FirstOrDefault(student => student.Id.Equals(id));
            oldStudent.Name = student.Name;
            //new ResponseEntity<>(HttpStatus.NO_CONTENT);
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var oldStudent = students.FirstOrDefault(student => student.Id.Equals(id));
            students.Remove(oldStudent);
        }
    }
}
