using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _4SeminarskiRad.Models
{
    public class Enrollment
    {
        [Key]
        public int EnrollmentId { get; set; }


        [Display(Name = "Datum upisa")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? EnrollmentDate
        {
            get
            {
                return this.today.HasValue
                    ? this.today.Value :
                    DateTime.Today;
            }
            set
            {
                this.today = value;
            }
        }
        private DateTime? today = null;


        [Required(ErrorMessage = "Ime je obavezno polje.")]
        [Display(Name = "Ime")]
        public string EnrollmentFirstName { get; set; }


        [Required(ErrorMessage = "Prezime je obavezno polje.")]
        [Display(Name = "Prezime")]
        public string EnrollmentLastName { get; set; }


        [Required(ErrorMessage = "Adresa je obavezno polje.")]
        [Display(Name = "Adresa")]
        public string EnrollmentAddress { get; set; }


        [Required(ErrorMessage = "Email je obavezno polje.")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string EnrollmentEmail { get; set; }


        [Required(ErrorMessage = "Telefon je obavezno polje.")]
        [Display(Name = "Telefon")]
        public string EnrollmentPhone { get; set; }



        public int CourseId { get; set; }


        [Display(Name = "Predbilježba prihvaćena")]
        public bool EnrollmentAccepted { get; set; }
        public virtual Course Course { get; set; }
    }
}