using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Uplift.Models
{
    public class KategorijaProizvoda
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Naziv")]
        public string Naziv { get; set; }
        [Required]
        [Display(Name ="Prikaz redoslijeda")]
        public int PrikazRedoslijeda { get; set; }
    }
}
