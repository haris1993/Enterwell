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
        public class FakturaController : Controller
        {
            private readonly IUnitOfWork _unitOfWork;

            public FakturaController(IUnitOfWork unitOfWork)
            {
                _unitOfWork = unitOfWork;
            }
            public IActionResult Index()
            {
                return View();
            }


            // GET: Contacts/Upsert/5
            public IActionResult Upsert(int? id)
            {
                Faktura faktura = new Faktura();
                if (id == null)
                {

                    return View(faktura);
                }

            faktura = _unitOfWork.FakturaRepository.Get(id.GetValueOrDefault());
                if (faktura == null)
                {
                    return NotFound();
                }
                return View(faktura);
            }

            // POST: Contacts/Upsert/5
            // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
            // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Upsert(Faktura faktura)
            {

                if (ModelState.IsValid)
                {
                    if (faktura.Id == 0)
                    {
                        _unitOfWork.FakturaRepository.Add(faktura);
                    }
                    else
                    {
                        _unitOfWork.FakturaRepository.Update(faktura);
                    }
                    _unitOfWork.Save();
                    return RedirectToAction(nameof(Index));
                }
                return View(faktura);

            }


            #region API Calls

            public IActionResult GetAll()
            {

                return Json(new { data = _unitOfWork.FakturaRepository.GetAll() });
            }

            [HttpDelete]
            public IActionResult Delete(int id)
            {
                var objFromDb = _unitOfWork.FakturaRepository.Get(id);
                if (objFromDb == null)
                {
                    return Json(new { success = false, message = "Error while deleting." });
                }
                _unitOfWork.FakturaRepository.Remove(objFromDb);
                _unitOfWork.Save();
                return Json(new { success = true, message = "Delete success." });

            }
            #endregion
        }
    }
