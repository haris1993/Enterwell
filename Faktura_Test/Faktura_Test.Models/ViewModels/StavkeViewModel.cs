using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace Uplift.Models.ViewModels
{
    public class StavkeViewModel
    {
        public StavkeFaktura Stavke { get; set; }
        public IEnumerable<SelectListItem> Proizvodi { get; set; }
        public IEnumerable<SelectListItem> Fakture { get; set; }
        public IEnumerable<SelectListItem> KategorijaProizvod { get; set; }
    }
}
