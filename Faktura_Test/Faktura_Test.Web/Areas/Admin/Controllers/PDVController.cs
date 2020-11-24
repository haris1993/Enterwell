using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Faktura_Test.Models;
using Microsoft.AspNetCore.Mvc;
using Uplift.DataAccess.Data.Repository.IRepository;

namespace Faktura_Test.Web.Areas.Admin.Controllers
{

    [Area("Admin")]
    public class PDVController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public PDVController(IUnitOfWork unitOfWork)
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
            PDV pdv = new PDV();
            if (id == null)
            {

                return View(pdv);
            }

            pdv = _unitOfWork.PDVRepository.Get(id.GetValueOrDefault());
            if (pdv == null)
            {
                return NotFound();
            }
            return View(pdv);
        }

        // POST: Contacts/Upsert/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(PDV pdv)
        {

            if (ModelState.IsValid)
            {
                if (pdv.Id == 0)
                {
                    _unitOfWork.PDVRepository.Add(pdv);
                }
                else
                {
                    _unitOfWork.PDVRepository.Update(pdv);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(pdv);

        }


        #region API Calls

        public IActionResult GetAll()
        {

            return Json(new { data = _unitOfWork.PDVRepository.GetAll() });
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.PDVRepository.Get(id);
            if (objFromDb == null)
            {
                return Json(new { success = false, message = "Error while deleting." });
            }
            _unitOfWork.PDVRepository.Remove(objFromDb);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Delete success." });

        }
        #endregion
    }
}
