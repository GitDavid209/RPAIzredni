using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;

namespace DrugaMVC.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name = "Priimek in ime")]
        [Required(ErrorMessage ="Ime je obvezen podatek")]
        public string Ime { get; set; }
        [Range(5,50)]
        public int Starost { get; set; }
    }
}