using Microsoft.EntityFrameworkCore;


namespace StudentManagement.Models
{
    public class APIDbContext:DbContext
    {
        public APIDbContext(DbContextOptions option): base(option) 
        {
            
        }
       
        public DbSet<Student>  Students { get; set; }
    }
}
