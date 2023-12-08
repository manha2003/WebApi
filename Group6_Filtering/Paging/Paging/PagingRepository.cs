using System.Xml.Linq;

namespace Paging
{
    public class PagingRepository
    {
        private readonly ApplicationContext _dbContext;

        public PagingRepository(ApplicationContext dbContext)
        {
            _dbContext = dbContext;
        }

        public PaginatedList<Student> GetPagedData(int pageNumber, int pageSize)
        {
            var students = _dbContext.Students.AsQueryable();
            return PaginatedList<Student>.Create(students, pageSize, pageNumber);
           
        }

        public IEnumerable<Student> GetFilterByName(string? name)
        {
            IEnumerable<Student> Students = _dbContext.Students;

            if (!String.IsNullOrEmpty(name)){
                Students = Students.Where(x => x.StudentName.Contains(name));
            }

            return Students;
        }
     
    }
}
