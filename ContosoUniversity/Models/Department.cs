//kriner-mvc5
//The Department class creates the Department entity with the DepartmentID, Name, Budget, StartDate, InstructorID,
//Administrator, and Courses properties.
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }

        //kriner-mvc5
        //The column attribute changes the Column name mapping in the database.
        [DataType(DataType.Currency)]
        [Column(TypeName = "money")]
        public decimal Budget { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        public int? InstructorID { get; set; }

        //kriner-mvc5
        //The Administrator property holds an Instructor property as an Administrator is generally an Instructor.
        //The Courses collection is present because a Department generally contains multiple Courses within it.
        public Instructor Administrator { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}