using System;

namespace EntityFrameworkCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Student object.
            Student student = new Student();

            // Assign values to the student's properties.
            student.FirstName = "Selcuk";
            student.LastName = "Kaplan";

            // Create a database context.
            using (StudentContext context = new StudentContext())
            {
                // Add the student to the Students table.
                context.Students.Add(student);

                // Save the student to the database.
                context.SaveChanges();
            }

            // Display a message confirming that the student was added.
            Console.WriteLine("Student was successfully added to the database.");

            Console.ReadLine();
        }
    }
}