using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Uplift.DataAccess.Data.Repository.IRepository;
using Uplift.Models;

namespace Uplift.DataAccess.Data.Repository
{
    public class ProizvodRepository : Repository<Proizvod>, IProizvodRepository
    {
        private readonly ApplicationDbContext _db;

        public ProizvodRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetProizvodListForDropDown()
        {
            return _db.Proizvod.Select(i => new SelectListItem()
            {
                Text = i.Naziv,
                Value = i.Id.ToString()
            });
        }

        public void Update(Proizvod proizvod)
        {
            var objFromDb = _db.Proizvod.FirstOrDefault(s => s.Id == proizvod.Id);

            objFromDb.Naziv = proizvod.Naziv;
            objFromDb.Red_Broj_proizvoda = proizvod.Red_Broj_proizvoda;
            objFromDb.JedinicaMjere = proizvod.JedinicaMjere;

            _db.SaveChanges();
        }
    }
}
