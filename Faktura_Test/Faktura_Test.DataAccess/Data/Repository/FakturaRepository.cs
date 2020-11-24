using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Uplift.DataAccess.Data.Repository.IRepository;
using Uplift.Models;

namespace Uplift.DataAccess.Data.Repository
{
    public class FakturaRepository : Repository<Faktura>, IFakturaRepository
    {
        private readonly ApplicationDbContext _db;

        public FakturaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetFakturaListForDropDown()
        {
            return _db.Faktura.Select(i => new SelectListItem()
            {
                Text = i.Naziv,
                Value = i.Id.ToString()
            });
        }

        public void Update(Faktura faktura)
        {
            var objFromDb = _db.Faktura.FirstOrDefault(s => s.Id == faktura.Id);

            objFromDb.Naziv = faktura.Naziv;
            objFromDb.Red_Broj_faktura = faktura.Red_Broj_faktura;
            objFromDb.Datum_Stvaranja_Fakture = faktura.Datum_Stvaranja_Fakture;
            objFromDb.Datum_Dospjeca_Fakture = faktura.Datum_Dospjeca_Fakture;
            objFromDb.Kolicina = objFromDb.Kolicina;

            _db.SaveChanges();
        }

    }
}
