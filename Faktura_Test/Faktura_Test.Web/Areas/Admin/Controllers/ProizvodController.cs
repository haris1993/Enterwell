using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Uplift.DataAccess.Data.Repository.IRepository;
using Uplift.Models;

namespace Uplift.Areas.Admin.Controllers
{
    
        [Area("Admin")]
        public class ProizvodController : Controller
        {
            private readonly IUnitOfWork _unitOfWork;

            public ProizvodController(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }

            public IActionResult Index()
            {
                return View();
            }

            public IActionResult Upsert(int? id)
            {
                Proizvod proizvod = new Proizvod();
                if (id == null)
                {
                    return View(proizvod);
                }
                proizvod = _unitOfWork.ProizvodRepository.Get(id.GetValueOrDefault());
                if (proizvod == null)
                {
                    return NotFound();
                }
                return View(proizvod);
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Upsert(Proizvod proizvod)
            {
                if (ModelState.IsValid)
                {
                    if (proizvod.Id == 0)
                    {
                        _unitOfWork.ProizvodRepository.Add(proizvod);
                    }
                    else
                    {
                        _unitOfWork.ProizvodRepository.Update(proizvod);
                    }
                    _unitOfWork.Save();
                    return RedirectToAction(nameof(Index));
                }
                return View(proizvod);
            }

            #region API CALLS

            [HttpGet]
            public IActionResult GetAll()
            {
                return Json(new { data = _unitOfWork.ProizvodRepository.GetAll() });
            }

            [HttpDelete]
            public IActionResult Delete(int id)
            {
                var objFromDb = _unitOfWork.ProizvodRepository.Get(id);
                if (objFromDb == null)
                {
                    return Json(new { success = false, message = "Error while deleting." });
                }

                _unitOfWork.ProizvodRepository.Remove(objFromDb);
                _unitOfWork.Save();
                return Json(new { success = true, message = "Delete successful." });

            }

            #endregion
        }
}