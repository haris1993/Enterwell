using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Uplift.Models
{
    public class Proizvod
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Naziv proizvoda")]
        public string Naziv { get; set; }

        [Required]
        [Display(Name = "Jedinica mjere")]
        public string JedinicaMjere { get; set; }

        [Required]
        [Display(Name = "Redni broj proizvoda")]
        public int Red_Broj_proizvoda { get; set; }
    }
}
