using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Uplift.Models
{
    public class ZaglavljeNarudzbe
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Ime")]

        public string Ime { get; set; }

        [Required]
        [Display(Name = "Broj telefona")]

        public string Broj_Telefona { get; set; }

        [Required]
        [Display(Name = "Email")]

        public string Email { get; set; }

        [Required]
        [Display(Name = "Adresa")]

        public string Adresa { get; set; }

        [Required]
        [Display(Name = "Grad")]

        public string Grad { get; set; }

        [Required]
        [Display(Name = "Postanski broj")]

        public string Postanski_Broj { get; set; }
        public DateTime DatumNarudzbe { get; set; }
        public string Status { get; set; }
        public string Komentar { get; set; }
        public int StavkeFakture_Kolicna { get; set; }


    }
}
