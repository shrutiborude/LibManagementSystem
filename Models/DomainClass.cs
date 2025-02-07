using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibManagementSystem_Updated.Models
{
    public enum Role
    {
        Student,
        Librarian
    }

    public abstract class Person
    {
        [Key]  // Primary Key
        public int Id { get; set; }

        public string Name { get; set; }
        public string Contact { get; set; }

        public Role UserRole { get; set; }
    }

    public class Student : Person
    {
        [Required]
        public string StudentID { get; set; }

        public Student()
        {
            UserRole = Role.Student;
        }
    }

    public class Librarian : Person
    {
        [Required]
        public string EmployeeID { get; set; }

        public Librarian()
        {
            UserRole = Role.Librarian;
        }
    }


    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Author { get; set; }
    }
}
