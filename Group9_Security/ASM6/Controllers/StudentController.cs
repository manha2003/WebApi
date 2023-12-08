using ASM6.Data;
using ASM6.Models.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASM6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StudentsController : ControllerBase
    {
        private readonly ApplicationDbContext applicationDbContext;

        public StudentsController(ApplicationDbContext applicationDbContext)
        {
            this.applicationDbContext = applicationDbContext;
        }

        // GET: api/<StudentsController>
        [HttpGet]
        [Authorize(Roles ="Reader, Writer")]
        public List<Student> Get()
        {
            return applicationDbContext.Students.ToList();
        }

        // GET api/<StudentsController>/5
        [HttpGet("{id}")]
        [Authorize(Roles = "Reader, Writer")]
        public Student Get(int id)
        {
            return applicationDbContext.Students.FirstOrDefault(m => m.Id.Equals(id));
        }

        // POST api/<StudentsController>
        [HttpPost]
        [Authorize(Roles = "Writer")]
        public Student Post([FromBody] Student student)
        {
            applicationDbContext.Students.Add(student);
            applicationDbContext.SaveChanges();
            return student;
        }

        // PUT api/<StudentsController>/5
        [HttpPut("{id}")]
        [Authorize(Roles = "Writer, Reader")]
        public void Put(int id, [FromBody] Student student)
        {
            var oldStudent = applicationDbContext.Students.FirstOrDefault(student => student.Id.Equals(id));
            oldStudent.Name = student.Name;

            applicationDbContext.SaveChanges();
            //new ResponseEntity<>(HttpStatus.NO_CONTENT);
        }

        // DELETE api/<StudentsController>/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Writer")]
        public void Delete(int id)
        {
            var oldStudent = applicationDbContext.Students.FirstOrDefault(student => student.Id.Equals(id));
            applicationDbContext.Students.Remove(oldStudent);

            applicationDbContext.SaveChanges();
        }
    }
}
