using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Uplift.DataAccess.Data.Repository.IRepository;
using Uplift.Models.ViewModels;

namespace Uplift.Areas.Admin.Controllers
{
    
        [Area("Admin")]
        public class StavkeFakturaController : Controller
        {
            private readonly IUnitOfWork _unitOfWork;
            private readonly IWebHostEnvironment _hostEnvironment;

            [BindProperty]
            public StavkeViewModel StavkeVM { get; set; }

            public StavkeFakturaController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
            {
                _unitOfWork = unitOfWork;
                _hostEnvironment = hostEnvironment;
            }

            public IActionResult Upsert(int? id)
            {
            StavkeVM = new StavkeViewModel()
                {
                    Stavke = new Models.StavkeFaktura(),
                    Proizvodi = _unitOfWork.ProizvodRepository.GetProizvodListForDropDown(),
                    Fakture = _unitOfWork.FakturaRepository.GetFakturaListForDropDown(),
                    KategorijaProizvod = _unitOfWork.KategorijaProizvodaRepository.GetKategorijaProizvodaListForDropDown(),
                };
                if (id != null)
                {
                    StavkeVM.Stavke = _unitOfWork.StavkeFakturaRepository.Get(id.GetValueOrDefault());
                }

                return View(StavkeVM);
            }

            public IActionResult Index()
            {
                return View();
            }

            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Upsert()
            {
                if (ModelState.IsValid)
                {
                    string webRootPath = _hostEnvironment.WebRootPath;
                    var files = HttpContext.Request.Form.Files;
                    if (StavkeVM.Stavke.Id == 0)
                    {
                        //New Service
                        string fileName = Guid.NewGuid().ToString();
                        var uploads = Path.Combine(webRootPath, @"images\stavke");
                        var extension = Path.GetExtension(files[0].FileName);

                        using (var fileStreams = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                        {
                            files[0].CopyTo(fileStreams);
                        }
                    StavkeVM.Stavke.Slika_Url = @"\images\stavke\" + fileName + extension;

                        _unitOfWork.StavkeFakturaRepository.Add(StavkeVM.Stavke);
                    }
                    else
                    {
                        //Edit Service
                        var serviceFromDb = _unitOfWork.StavkeFakturaRepository.Get(StavkeVM.Stavke.Id);
                        if (files.Count > 0)
                        {
                            string fileName = Guid.NewGuid().ToString();
                            var uploads = Path.Combine(webRootPath, @"images\stavke");
                            var extension_new = Path.GetExtension(files[0].FileName);

                            var imagePath = Path.Combine(webRootPath, serviceFromDb.Slika_Url.TrimStart('\\'));
                            if (System.IO.File.Exists(imagePath))
                            {
                                System.IO.File.Delete(imagePath);
                            }

                            using (var fileStreams = new FileStream(Path.Combine(uploads, fileName + extension_new), FileMode.Create))
                            {
                                files[0].CopyTo(fileStreams);
                            }
                            StavkeVM.Stavke.Slika_Url = @"\images\stavke\" + fileName + extension_new;
                        }
                        else
                        {
                            StavkeVM.Stavke.Slika_Url = serviceFromDb.Slika_Url;
                        }

                        _unitOfWork.StavkeFakturaRepository.Update(StavkeVM.Stavke);
                    }
                    _unitOfWork.Save();
                    return RedirectToAction(nameof(Index));
                }
                else
                {
                    StavkeVM.Proizvodi = _unitOfWork.ProizvodRepository.GetProizvodListForDropDown();
                    StavkeVM.Fakture = _unitOfWork.FakturaRepository.GetFakturaListForDropDown();
                StavkeVM.KategorijaProizvod = _unitOfWork.KategorijaProizvodaRepository.GetKategorijaProizvodaListForDropDown();
                    return View(StavkeVM);
                }
            }

            #region API Calls
            public IActionResult GetAll()
            {
                return Json(new { data = _unitOfWork.StavkeFakturaRepository.GetAll(includeProperties: "Proizvod,Faktura") });
            }

            [HttpDelete]
            public IActionResult Delete(int id)
            {
                var serviceFromDb = _unitOfWork.StavkeFakturaRepository.Get(id);
                string webRootPath = _hostEnvironment.WebRootPath;
                var imagePath = Path.Combine(webRootPath, serviceFromDb.Slika_Url.TrimStart('\\'));
                if (System.IO.File.Exists(imagePath))
                {
                    System.IO.File.Delete(imagePath);
                }

                if (serviceFromDb == null)
                {
                    return Json(new { success = false, message = "Error while deleting." });
                }

                _unitOfWork.StavkeFakturaRepository.Remove(serviceFromDb);
                _unitOfWork.Save();
                return Json(new { success = true, message = "Deleted Successfully." });
            }

            #endregion
        }
}
