# Entity Framework Code First Console Application

## Overview

This project demonstrates the basic use of **Entity Framework Code First** in a C# console application.

The application creates a basic Student database using Entity Framework and adds one student record to the database.

## Technologies Used

* C#
* .NET Framework
* Entity Framework 6
* SQL Server LocalDB
* Visual Studio

## What I Learned

Through this assignment, I learned how to:

* Create an Entity Framework Code First application.
* Create a model class.
* Create a database context using `DbContext`.
* Use `DbSet` to represent a database table.
* Configure a database connection string.
* Add a record to a database.
* Use `SaveChanges()` to save data to the database.

## Project Structure

```text
EntityFrameworkCodeFirst/
│
├── App.config
├── Program.cs
├── Student.cs
├── StudentContext.cs
└── EntityFrameworkCodeFirst.csproj
```

## Student Class

The `Student` class contains:

* `StudentId`
* `FirstName`
* `LastName`

Entity Framework uses this class as the model for the Student database table.

## StudentContext

The `StudentContext` class inherits from `DbContext` and contains a `DbSet<Student>` property.

This allows Entity Framework to work with the Student records in the database.

## How the Application Works

1. A new Student object is created.
2. The student's first and last names are assigned.
3. A `StudentContext` object is created.
4. The student is added using `context.Students.Add()`.
5. `context.SaveChanges()` saves the student to the database.
6. Entity Framework Code First creates the database structure based on the model.

## Example Output

```text
Student was successfully added to the database.
```

## Code First

Code First allows developers to define database models using C# classes. Entity Framework uses these classes to create and work with the database.

This approach allows the application code to define the structure of the data instead of manually creating the database tables first.

## Author

Selcuk Kaplan
