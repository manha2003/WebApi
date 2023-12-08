using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Validation.Controllers
{
    [Route("api/[controller]")]
    //[ApiController]
    public class StudentController : ControllerBase
    {
        [HttpPost]
        public IActionResult Post(StudentDTO studentDTO) { 
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError(nameof(StudentDTO.Id), "The Id field is required");
                return BadRequest(ModelState);
            }
            return Ok(studentDTO);
        }
    }

    
}
