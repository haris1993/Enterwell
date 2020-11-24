using System;
using System.Collections.Generic;
using System.Text;

namespace Uplift.Models.ViewModels
{
    public class NarudzbaViewModel
    {
        public ZaglavljeNarudzbe ZaglavljeNarudzbe { get; set; }
        public IEnumerable<DetaljiNarudzbe> DetaljiNarudzbe { get; set; }
    }
}
