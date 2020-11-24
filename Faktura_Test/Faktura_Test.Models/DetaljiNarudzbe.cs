using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Uplift.Models
{
    public class DetaljiNarudzbe
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ZaglavljeNarudzbeId { get; set; }

        [ForeignKey("ZaglavljeNarudzbeId")]
        public ZaglavljeNarudzbe ZaglavljeNarudzbe { get; set; }

        [Required]
        public int StavkaFakturaId { get; set; }

        [ForeignKey("StavkaFakturaId")]
        public StavkeFaktura StavkeFaktura { get; set; }

        [Required]
        public string StavkeFaktureNaziv { get; set; }
        [Required]
        public int Kolicina { get; set; }

        [Required]
        public double CijenaBezPoreza { get; set; }

        
        public double CijenaSaPorezom { get; set; }
    }
}
