//kriner-mvc5
//The Instructor class creates an model for an Instructor in the ContosoUniversity program with the properties ID,
//LastName, FirstMidName, HireDate, FullName, CourseAssignments, and OfficeAssignments.
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    //kriner-mvc9
    //Derived the Instructor class from the Person base class and removed all redundant properties.
    public class Instructor : Person
    {
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Hire Date")]
        public DateTime HireDate { get; set; }

        public ICollection<CourseAssignment> CourseAssignments { get; set; }
        public OfficeAssignment OfficeAssignment { get; set; }
    }
}