using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Uplift.DataAccess.Data.Repository.IRepository;
using Uplift.Models;

namespace Uplift.DataAccess.Data.Repository
{
    public class KategorijaProizvodaRepository : Repository<KategorijaProizvoda>, IKategorijaProizvodaRepository
    {
        private readonly ApplicationDbContext _db;

        public KategorijaProizvodaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetKategorijaProizvodaListForDropDown()
        {
            return _db.KategorijaProizvoda.Select(i => new SelectListItem()
            {
                Text = i.Naziv.ToString(),
                Value = i.Id.ToString()
            });
        }

        public void Update(KategorijaProizvoda kategorija)
        {
            var objFromDb = _db.KategorijaProizvoda.FirstOrDefault(s => s.Id == kategorija.Id);

            objFromDb.Naziv = kategorija.Naziv;
            objFromDb.PrikazRedoslijeda = kategorija.PrikazRedoslijeda;


            _db.SaveChanges();
        }

    }
}
