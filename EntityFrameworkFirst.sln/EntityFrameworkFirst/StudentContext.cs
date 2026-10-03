using System.Data.Entity;

namespace EntityFrameworkCodeFirst
{
    // Database context used by Entity Framework.
    public class StudentContext : DbContext
    {
        // Constructor uses the connection string named StudentContext.
        public StudentContext() : base("name=StudentContext")
        {
        }

        // Students represents the Student table in the database.
        public DbSet<Student> Students { get; set; }
    }
}