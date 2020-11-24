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
        public class KategorijaProizvodaController : Controller
        {
            private readonly IUnitOfWork _unitOfWork;

            public KategorijaProizvodaController(IUnitOfWork unitOfWork)
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
                KategorijaProizvoda kategorija = new KategorijaProizvoda();
                if (id == null)
                {

                    return View(kategorija);
                }

                kategorija = _unitOfWork.KategorijaProizvodaRepository.Get(id.GetValueOrDefault());
                if (kategorija == null)
                {
                    return NotFound();
                }
                return View(kategorija);
            }

            // POST: Contacts/Upsert/5
            // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
            // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Upsert(KategorijaProizvoda kategorija)
            {

                if (ModelState.IsValid)
                {
                    if (kategorija.Id == 0)
                    {
                        _unitOfWork.KategorijaProizvodaRepository.Add(kategorija);
                    }
                    else
                    {
                        _unitOfWork.KategorijaProizvodaRepository.Update(kategorija);
                    }
                    _unitOfWork.Save();
                    return RedirectToAction(nameof(Index));
                }
                return View(kategorija);

            }


            #region API Calls

            public IActionResult GetAll()
            {

                return Json(new { data = _unitOfWork.KategorijaProizvodaRepository.GetAll() });
            }

            [HttpDelete]
            public IActionResult Delete(int id)
            {
                var objFromDb = _unitOfWork.KategorijaProizvodaRepository.Get(id);
                if (objFromDb == null)
                {
                    return Json(new { success = false, message = "Error while deleting." });
                }
                _unitOfWork.KategorijaProizvodaRepository.Remove(objFromDb);
                _unitOfWork.Save();
                return Json(new { success = true, message = "Delete success." });

            }
            #endregion
        }
}
