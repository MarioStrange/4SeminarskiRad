using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _4SeminarskiRad.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }


        [Display(Name = "Naziv seminara")]
        public string CourseName { get; set; }


        [Display(Name = "Opis seminara")]
        [DataType(DataType.MultilineText)]
        public string CourseDescription { get; set; }


        [Display(Name = "Datum seminara")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime CourseDate { get; set; }


        [Display(Name = "Seminar popunjen")]
        public bool CourseAvailable { get; set; }


        [Display(Name = "Broj polaznika")]
        public int NumberOfStudents { get; set; }


        // Navigation property
        public virtual ICollection<Enrollment> Enrollments { get; set; }

    }
}