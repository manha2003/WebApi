using Microsoft.AspNetCore.Mvc;

namespace Paging.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class StudentsController : ControllerBase
	{
        private readonly PagingRepository _repository;

        private readonly ILogger<StudentsController> _logger;
		private List<Student> students;

		ApplicationContext _context;

		public StudentsController(ILogger<StudentsController> logger, ApplicationContext context ,PagingRepository repository) 
		{
			_context = context;
			_logger = logger;
			_repository = repository;		
		
		}



		[HttpGet("{pageNumber}/{pageSize}")]
		//https://localhost:7043/Students/1/5
		public IEnumerable<Student> Page(int pageNumber,int pageSize)
		{

			var paged = _repository.GetPagedData(pageNumber, pageSize);
			return paged;  
				
		}
		//https://localhost:7043/Students/bunpro
		
		
		[HttpGet("{name}")]
		public IEnumerable<Student> Filter(string? name)
		{

			var filterStudentByName = _repository.GetFilterByName(name);

            return filterStudentByName;

		}
		////https://localhost:7043/Students?pagesize=5&pagenumber=1
		//[HttpGet()]
		//public IEnumerable<Student> Page()
		//{

		//	int pageSize = 5;
		//	int pageNumber = 1;
		//	if (HttpContext.Request.Query.Count > 0)
		//	{
		//		pageSize = Int32.Parse(HttpContext.Request.Query["pagesize"]);
		//		pageNumber = Int32.Parse(HttpContext.Request.Query["pagenumber"]);
		//	}
		//	var result = PaginatedList<Student>.Create(students, pageSize, pageNumber);
		//	Console.WriteLine(result.PageIndex);
		//	return result;
		//}
	}
}