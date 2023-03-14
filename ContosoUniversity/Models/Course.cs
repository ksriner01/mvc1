//kriner-mvc1
//This code creates the Course entity with properites that describe the Course.
//This includes the CourseID, the title of the course, and the amount of credits the Course gives.
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Course
    {
        //kriner-mvc5
        //Displays the column name as Number. The DatabaseGenerated specifies that the primary key is provided by the user instead of
        //the database.
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int CourseID { get; set; }
        //kriner-mvc5
        //Sets the string length to 50 and the minimum length 3.
        [StringLength(50, MinimumLength = 3)]
        public string Title { get; set; }
        [Range(0, 5)]
        public int Credits { get; set; }

        //kriner-mvc5
        //The DepartmentID points to the Department entity and creates a foreign key for it. 
        public int DepartmentID { get; set; }

        //kriner-mvc5
        //Adds the Department and CourseAssignments collection properties.
        public Department Department { get; set; }
        public ICollection<Enrollment> Enrollments { get; set; }
        public ICollection<CourseAssignment> CourseAssignments { get; set; }
    }
}