using System;

namespace EntityFrameworkCodeFirst
{
    // Represents a Student entity/table in the database.
    public class Student
    {
        // Primary key for the Student table.
        public int StudentId { get; set; }

        // Student's first name.
        public string FirstName { get; set; }

        // Student's last name.
        public string LastName { get; set; }
    }
}