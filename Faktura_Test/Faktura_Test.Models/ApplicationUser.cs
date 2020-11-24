using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Uplift.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [Display(Name = "Ime")]

        public string Name { get; set; }
        [Display(Name = "Adresa")]

        public string StreetAddress { get; set; }
        [Display(Name = "Grad")]

        public string City { get; set; }
        [Display(Name = "Provincija")]

        public string State { get; set; }
        [Display(Name = "Postanski broj")]

        public string PostalCode { get; set; }

    }
}
