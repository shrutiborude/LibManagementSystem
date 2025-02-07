namespace LibManagementSystem_Updated.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student
    {
        public int Id { get; set; }

        [Required]
        public string StudentID { get; set; }

        public string Name { get; set; }

        public string Contact { get; set; }

        public int UserRole { get; set; }
    }
}
