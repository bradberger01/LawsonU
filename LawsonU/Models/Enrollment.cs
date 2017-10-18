using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LawsonU.Models
{
    public class Enrollment
    {
        [Key]
        public int Course_StudentID { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("Student")]
        public int StudentID { get; set; }
        public Student Student { get; set; }
        
        [System.ComponentModel.DataAnnotations.Schema.ForeignKey("Course")]
        public int CourseID { get; set; }
        public Course Course { get; set; }

    }
}