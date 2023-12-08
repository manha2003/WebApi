using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using asm_6_restfull_api;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Net;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.AspNetCore.Http.HttpResults;

namespace asm_6_restfull_api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        /*private readonly asm_6_restfull_apiContext _context;

        public StudentsController(asm_6_restfull_apiContext context)
        {
            _context = context;
        }*/
        private /*readonly*/ static List<Students> _context = new List<Students>()
        {
            new Students() { Id = 1, Name = "test1", Grade = "test1"},
            new Students() { Id = 2, Name = "test2", Grade = "test2"},
            new Students() { Id = 3, Name = "test3", Grade = "test3"}
        };

        // GET: api/Students
        [HttpGet]
        public ActionResult<IEnumerable<Students>> GetStudents()
        {
          if (_context == null)
          {
              return NotFound();
          }
            return _context;
        }

        // GET: api/Students/5
        [HttpGet("{id}")]
        public IResult GetStudents(int id)
        {
          if (_context == null)
          {
              return Results.NotFound();
          }
            var students = _context.FirstOrDefault(s => s.Id == id);

            if (students == null)
            {
                return Results.NotFound();
            }

            return Results.Ok(students);
        }

        // PUT: api/Students/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public IResult PutStudents(int id,[Bind("id,name,grade")]Students students)
        {
            if (id != students.Id)
            {
                return Results.BadRequest();
            }

            int index = _context.IndexOf(_context.FirstOrDefault(s =>  s.Id == students.Id)!);
            if (index == -1)
            {
                return Results.NotFound();
            }
                        
            _context[index] = students;

            return Results.NoContent();
        }

        // POST: api/Students
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public IResult PostStudents([Bind("id,name,grade")] Students students)
        {
            _context.Add(students);

            CreatedAtAction("GetStudents", new { id = students.Id }, students);
            return Results.Created(students.Id.ToString(),students);
        }

        // DELETE: api/Students/5
        [HttpDelete("{id}")]
        public IResult DeleteStudents(int id)
        {
            if (_context == null)
            {
                return Results.NotFound();
            }
            var students = _context.FirstOrDefault(s => s.Id == id);
            if (students == null)
            {
                return Results.NotFound();
            }

            _context.Remove(students);

            return Results.NoContent();
        }
    }
}
