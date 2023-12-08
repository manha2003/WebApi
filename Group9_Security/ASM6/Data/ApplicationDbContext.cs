using ASM6.Models.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ASM6.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> dbContextOptions) : base(dbContextOptions)
        {
            
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var students = new List<Student>
            {
                new Student(108, "Peter", "DHTH20A"),
                new Student(109, "Khang", "DHTH20A"),
                new Student(110, "Thao", "DHTH20A"),
            };

            builder.Entity<Student>().HasData(students);
        }
    }

}

