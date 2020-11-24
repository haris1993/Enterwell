using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Uplift.DataAccess.Data.Repository.IRepository;
using Uplift.Models.ViewModels;
using Uplift.Utility;

namespace Uplift.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NarudzbaController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public NarudzbaController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Details(int id)
        {
            NarudzbaViewModel narudzbaVM = new NarudzbaViewModel()
            {
                ZaglavljeNarudzbe = _unitOfWork.ZaglavljeNarudzbeRepository.Get(id),
                DetaljiNarudzbe = _unitOfWork.DetaljiNarudzbeRepository.GetAll(filter: o => o.ZaglavljeNarudzbeId == id)
            };
            return View(narudzbaVM);
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Approve(int id)
        {
            var orderFromDb = _unitOfWork.ZaglavljeNarudzbeRepository.Get(id);
            if (orderFromDb == null)
            {
                return NotFound();
            }
            _unitOfWork.ZaglavljeNarudzbeRepository.ChangeZaglavljeNarudzbeStatus(id, SD.StatusApproved);
            return View(nameof(Index));
        }

        public IActionResult Reject(int id)
        {
            var orderFromDb = _unitOfWork.ZaglavljeNarudzbeRepository.Get(id);
            if (orderFromDb == null)
            {
                return NotFound();
            }
            _unitOfWork.ZaglavljeNarudzbeRepository.ChangeZaglavljeNarudzbeStatus(id, SD.StatusRejected);
            return View(nameof(Index));
        }

        #region API Calls

        public IActionResult GetAllOrders()
        {
            return Json(new { data = _unitOfWork.ZaglavljeNarudzbeRepository.GetAll() });
        }

        public IActionResult GetAllPendingOrders()
        {
            return Json(new { data = _unitOfWork.ZaglavljeNarudzbeRepository.GetAll(filter: o => o.Status == SD.StatuSubmitted) });
        }

        public IActionResult GetAllApprovedOrders()
        {
            return Json(new { data = _unitOfWork.ZaglavljeNarudzbeRepository.GetAll(filter: o => o.Status == SD.StatusApproved) });
        }

        #endregion
    }
}
