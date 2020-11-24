using Faktura_Test.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Uplift.Models
{
    public class StavkeFaktura
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Naziv")]
        public string Naziv { get; set; }

        [Required]
        [Display(Name = "Opis stavke")]
        public string Opis { get; set; }

        [DataType(DataType.ImageUrl)]
        [Display(Name = "Slika")]
        public string Slika_Url { get; set; }

        [Required]

        [Display(Name = "Proizvod")]
        public int ProizvodId { get; set; }

        [ForeignKey("ProizvodId")]
        public Proizvod Proizvod { get; set; }

        [Display(Name = "Kategorija proizvoda")]
        public int? KategorijaProizvodId { get; set; }

        [ForeignKey("KategorijaProizvodId")]

        public KategorijaProizvoda KategorijaProizvoda { get; set; }

        [Required]
        [Display(Name = "Faktura")]
        public int FakturaId { get; set; }

        [ForeignKey("FakturaId")]
        public Faktura Faktura { get; set; }

        [Display(Name = "PDV")]
        public int? PDVId { get; set; }

        [ForeignKey("PDVId")]
        public PDV PDV { get; set; }

        [Required]
        [Display(Name = "Cijena")]
        public double Cijena { get; set; }

    }
}
