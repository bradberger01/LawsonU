using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LawsonU.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        [DisplayName ("Course Name")]
        public string Title { get; set; }
        public string Description { get; set; }
        [DisplayName("Credit Hours")]
        public double CreditHours { get; set; }
        [DisplayName("Class Size")]
        public int ClassSize { get; set; }
        [DisplayName("Passing Grade")]
        public double PassingGrade { get; set; }

        public virtual ICollection<Enrollment> Enrollment { get; set; }

    }
}