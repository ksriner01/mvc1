//kriner-mvc5
//The OfficeAssignment class creates a model for an office assignment for an instructor with the InstructorID, Location,
//and Instructor properties. The [Key] attribute specifies the primary key since InstructorID doesn't match the primary key
//naming convention.
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class OfficeAssignment
    {
        [Key]
        public int InstructorID { get; set; }
        [StringLength(50)]
        [Display(Name = "Office Location")]
        public string Location { get; set; }

        public Instructor Instructor { get; set; }
    }
}