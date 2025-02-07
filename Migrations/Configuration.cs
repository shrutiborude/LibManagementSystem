namespace LibManagementSystem_Updated.Migrations
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using LibManagementSystem_Updated.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<LibManagementSystem_Updated.Models.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LibManagementSystem_Updated.Models.MyDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            IList<Student> defaultStudent = new List<Student>();

            defaultStudent.Add(new Student() { Name = "Shruti", StudentID = "101" });
            defaultStudent.Add(new Student() { Name = "Sneha", StudentID = "102" });
            defaultStudent.Add(new Student() { Name = "Nidhi", StudentID = "103" });


            context.Students.AddOrUpdate(s => s.StudentID, defaultStudent.ToArray());

            IList<Librarian> defaultLibrarian = new List<Librarian>();

            defaultLibrarian.Add(new Librarian() { Name = "Atul", EmployeeID = "201" });
            defaultLibrarian.Add(new Librarian() { Name = "Ajay", EmployeeID = "202" });

            context.Librarians.AddOrUpdate(l => l.EmployeeID, defaultLibrarian.ToArray());

            IList<Book> defaultBook = new List<Book>();

            defaultBook.Add(new Book() { Name = "Harry Potter", Author = "Harry" });
            defaultBook.Add(new Book() { Name = "Arabian Nights", Author = "Arabian" });

            context.Books.AddOrUpdate(b => b.Id, defaultBook.ToArray());

            base.Seed(context);
        }
    }
}
