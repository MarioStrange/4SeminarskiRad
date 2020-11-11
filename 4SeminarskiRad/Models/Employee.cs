using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _4SeminarskiRad.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }



        [Display(Name = "Ime zaposlenika")]
        public string EmployeeFirstName { get; set; }



        [Display(Name = "Prezime zaposlenika")]
        public string EmployeeLastName { get; set; }



        [Display(Name = "Korisničko ime zaposlenika")]
        public string EmployeeUserName { get; set; }



        [Display(Name = "Lozinka zaposlenika")]
        public string EmployeePassword { get; set; }

    }
}