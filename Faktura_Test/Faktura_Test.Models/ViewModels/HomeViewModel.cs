using System;
using System.Collections.Generic;
using System.Text;

namespace Uplift.Models.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<KategorijaProizvoda> KategorijaProizvoda { get; set; }
        public IEnumerable<StavkeFaktura> StavkeFaktura { get; set; }
    }
}
