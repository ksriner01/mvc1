//kriner-mvc1
//This code creates the Enrollment entity which consists of properties that can describe an enrollment.
//This includes the enrollment, course, and student IDs as well as the Student, the course the student
//is enrolled in, and the Grade that the Student has.
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        //kriner-mvc5
        //Data annotation that displays the text No grade when null.
        [DisplayFormat(NullDisplayText = "No grade")]
        public Grade? Grade { get; set; }

        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}