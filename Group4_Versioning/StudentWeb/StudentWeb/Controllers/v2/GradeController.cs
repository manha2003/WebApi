using Microsoft.AspNetCore.Mvc;

namespace StudentWeb.Controllers.v2
{
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/grades")]
    [ApiController]

    public class GradeController : ControllerBase
    {
        public List<Grade> grades = new List<Grade>();
        public GradeController()
        {
            grades.Add(new Grade(10));
            grades.Add(new Grade(9));
            grades.Add(new Grade(7));
        }

        // GET: api/<StudentsController>
        [HttpGet]
        public List<Grade> Get()
        {
            return grades;
        }

    

       


    }
}
