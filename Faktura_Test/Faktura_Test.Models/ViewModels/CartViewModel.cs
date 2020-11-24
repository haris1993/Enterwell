using Faktura_Test.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Uplift.Models.ViewModels
{
    public class CartViewModel
    {
        public IList<StavkeFaktura> StavkeFaktura { get; set; }
        public StavkeFaktura Stavke { get; set; }

       
        public IEnumerable<SelectListItem> PDV { get; set; }

        public ZaglavljeNarudzbe ZaglavljeNarudzbe { get; set; }
        public double CijenaSaPorezom { get; set; }
    }
}
