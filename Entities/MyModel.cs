using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace LibManagementSystem_Updated.Entities
{
    public partial class MyModel : DbContext
    {
        public MyModel()
            : base("MyDBConnectionString")
        {
        }

        public virtual DbSet<Book> Books { get; set; }
        public virtual DbSet<Librarian> Librarians { get; set; }
        public virtual DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
