using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPISample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        List<Student> students = new List<Student>();
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
            return students.FirstOrDefault(m=>m.Id.Equals(id));
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
            var oldStudent = students.FirstOrDefault(student=>student.Id.Equals(id));
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
