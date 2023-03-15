//kriner-mvc1
//This code creates the student entity which consists of properties that can describe a student.
//This includes their full name and enrollment date for the courses they enrolled in.
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    //kriner-mvc9
    //Derives the Student class from the Person base class and removed all redundant properties.
    public class Student : Person
    {
        //kriner-mvc5
        //Sets the maximum string length to 50. Makes the property required and changes the displayed name
        //in the textbox rather to Last Name than the property name itself.

        //kriner-mvc5
        //Sets the maximum string length to 50. Makes the property required.

        //kriner-mvc5
        //Part of the System.ComponentModel.DataAnnotations.Schema which allows the change of what the
        //column in the database is named as. Changes the displayed name in the textbox rather to First
        //Name than the property name itself.

        //kriner-mvc5
        //Part of the System.ComponentModel.DataAnnotations namespace which can allow the specification of
        //property data types, in this case date.
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        //kriner-mvc5
        //Changes the displayed name in the textbox rather to Full Name than the property name itself.
        //The Full Name is the Last Name, and FirstMidName properties put together.


        public ICollection<Enrollment> Enrollments { get; set; }
    }
}