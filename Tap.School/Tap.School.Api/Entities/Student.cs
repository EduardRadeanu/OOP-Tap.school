using Microsoft.EntityFrameworkCore;

namespace Tap.School.Api.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Grade> Grades { get; set; }
    }
    public class Grade
    {
        public int Id { get; set; }
        public string CourseName { get; set; }
        public int grade { get; set; }
        public DbSet<Grade> Note { get; set; }
    }
}
