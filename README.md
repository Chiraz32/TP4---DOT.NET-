### ASP.NET MVC Student Management System with EF Core

This repository features an ASP.NET MVC application using Entity Framework Core with SQLite for student management:

### Components:

- **Model**: 
  - **Student**: Attributes include `id`, `first_name`, `last_name`, `phone_number`, `university`, `timestamp`, `course`.

- **Database Context**:
  - **UniversityContext**: Inherits `DbContext`, manages database connections and includes `DbSet<Student>`.

- **Repository**:
  - **StudentRepository**: Handles CRUD operations for `Student` using `UniversityContext`.

- **Views and Controllers**:
  - **Courses View**: Displays unique courses with links to view students by course.
  - **Students View**: Lists students filtered by a specific course parameter.

### Summary:

This project provides a streamlined ASP.NET MVC solution for student data management using Entity Framework Core with SQLite, emphasizing MVC architecture and efficient database interaction through repositories.
