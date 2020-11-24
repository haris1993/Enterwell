using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Uplift.DataAccess.Data.Repository.IRepository;
using Uplift.Models;

namespace Uplift.DataAccess.Data.Repository
{
    public class StavkeFakturaRepository : Repository<StavkeFaktura>, IStavkeFakturaRepository
    {
        private readonly ApplicationDbContext _db;

        public StavkeFakturaRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(StavkeFaktura stavke)
        {
            var objFromDb = _db.StavkeFaktura.FirstOrDefault(s => s.Id == stavke.Id);

            objFromDb.Naziv = stavke.Naziv;
            objFromDb.Opis = stavke.Opis;
            objFromDb.FakturaId = stavke.FakturaId;
            objFromDb.ProizvodId = stavke.ProizvodId;
            objFromDb.Slika_Url = stavke.Slika_Url;
            objFromDb.Cijena = stavke.Cijena;

            _db.SaveChanges();
        }
    }
}
