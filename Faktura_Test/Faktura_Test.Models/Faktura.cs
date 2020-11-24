using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Uplift.Models
{
    public class Faktura
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Naziv")]
        public string Naziv { get; set; }

        [Required]
        [Display(Name = "Redni broj proizvoda")]
        public int Red_Broj_faktura { get; set; }

        [Required]
        [Display(Name = "Datum stvaranja fakture")]
        public DateTime Datum_Stvaranja_Fakture { get; set; }

        [Required]
        [Display(Name = "Datum dospjeca fakture")]
        public DateTime Datum_Dospjeca_Fakture { get; set; }

        [Required]
        public int Kolicina { get; set; }


    }
}
