using Microsoft.EntityFrameworkCore;

namespace MVCHUALLPA.Models
{
    public class SchoolContext: DbContext
    {

        public DbSet<Course> Courses { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=LAB1504-13\SQLEXPRESS;Database=DBmarket;User Id=UserHuallpa;Password=1234567;trustservercertificate=True");
        }

    }
}

