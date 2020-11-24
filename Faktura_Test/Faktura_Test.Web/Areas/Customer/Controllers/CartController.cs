using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Uplift.DataAccess.Data.Repository;
using Uplift.DataAccess.Data.Repository.IRepository;
using Uplift.Extensions;
using Uplift.Models;
using Uplift.Models.ViewModels;
using Uplift.Utility;

namespace Uplift.Areas.Customer.Controllers
{
    [Area("Customer")]
    public class CartController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        [BindProperty]
        public CartViewModel CartVM { get; set; }

        public CartController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
            CartVM = new CartViewModel()
            {
                ZaglavljeNarudzbe = new Models.ZaglavljeNarudzbe(),
                StavkeFaktura = new List<StavkeFaktura>()
            };
        }

        public IActionResult Index()
        {
            if (HttpContext.Session.GetObject<List<int>>(SD.SessionCart) != null)
            {
                List<int> sessionList = new List<int>();
                sessionList = HttpContext.Session.GetObject<List<int>>(SD.SessionCart);
                foreach (var serviceId in sessionList)
                {
                    CartVM.StavkeFaktura.Add(_unitOfWork.StavkeFakturaRepository.GetFirstOrDefalut(u => u.Id == serviceId, includeProperties: "Proizvod,KategorijaProizvoda,Faktura"));
                }
            }

            return View(CartVM);
        }

        public IActionResult Summary()
        {
            if (HttpContext.Session.GetObject<List<int>>(SD.SessionCart) != null)
            {
                List<int> sessionList = new List<int>();
                sessionList = HttpContext.Session.GetObject<List<int>>(SD.SessionCart);
                foreach (var serviceId in sessionList)
                {
                    CartVM.StavkeFaktura.Add(_unitOfWork.StavkeFakturaRepository.GetFirstOrDefalut(u => u.Id == serviceId, includeProperties: "Proizvod,KategorijaProizvoda,Faktura"));
                }
            }
            CartVM.PDV = _unitOfWork.PDVRepository.GetPDVListForDropDown();

            return View(CartVM);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Summary")]
        public IActionResult SummaryPost()
        {
            if (HttpContext.Session.GetObject<List<int>>(SD.SessionCart) != null)
            {
                List<int> sessionList = new List<int>();
                sessionList = HttpContext.Session.GetObject<List<int>>(SD.SessionCart);
                CartVM.StavkeFaktura = new List<StavkeFaktura>();
                foreach (var serviceId in sessionList)
                {
                    CartVM.StavkeFaktura.Add(_unitOfWork.StavkeFakturaRepository.GetFirstOrDefalut(u => u.Id == serviceId, includeProperties: "Proizvod,KategorijaProizvoda,Faktura"));
                }
            }
            

            if (!ModelState.IsValid)
            {
                CartVM.PDV = _unitOfWork.PDVRepository.GetPDVListForDropDown();
                return View(CartVM);
            }
            else
            {
                CartVM.ZaglavljeNarudzbe.DatumNarudzbe = DateTime.Now;
                CartVM.ZaglavljeNarudzbe.Status = SD.StatuSubmitted;
                CartVM.ZaglavljeNarudzbe.StavkeFakture_Kolicna = CartVM.StavkeFaktura.Count;
                _unitOfWork.ZaglavljeNarudzbeRepository.Add(CartVM.ZaglavljeNarudzbe);
                _unitOfWork.Save();

                foreach (var item in CartVM.StavkeFaktura)
                {
                    DetaljiNarudzbe detaljiNarudzbe = new DetaljiNarudzbe
                    {
                        StavkaFakturaId = item.Id,
                        ZaglavljeNarudzbeId = CartVM.ZaglavljeNarudzbe.Id,
                        StavkeFaktureNaziv = item.Proizvod.Naziv,
                        CijenaBezPoreza = item.Cijena * item.Faktura.Kolicina,
                        CijenaSaPorezom = CartVM.CijenaSaPorezom,
                        Kolicina = item.Faktura.Kolicina
                    };

                    _unitOfWork.DetaljiNarudzbeRepository.Add(detaljiNarudzbe);

                }

                _unitOfWork.Save();
                HttpContext.Session.SetObject(SD.SessionCart, new List<int>());
                return RedirectToAction("OrderConfirmation", "Cart", new { id = CartVM.ZaglavljeNarudzbe.Id });
            }
        }

        public IActionResult OrderConfirmation(int id)
        {
            return View(id);
        }

        public IActionResult Remove(int serviceId)
        {
            List<int> sessionList = new List<int>();
            sessionList = HttpContext.Session.GetObject<List<int>>(SD.SessionCart);
            sessionList.Remove(serviceId);
            HttpContext.Session.SetObject(SD.SessionCart, sessionList);

            return RedirectToAction(nameof(Index));
        }
    }
}
