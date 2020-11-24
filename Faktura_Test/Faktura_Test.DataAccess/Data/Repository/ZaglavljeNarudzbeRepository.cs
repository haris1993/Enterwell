using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Uplift.DataAccess.Data.Repository.IRepository;
using Uplift.Models;

namespace Uplift.DataAccess.Data.Repository
{
    public class ZaglavljeNarudzbeRepository : Repository<ZaglavljeNarudzbe>, IZaglavljeNarudzbeRepository
    {
        private readonly ApplicationDbContext _db;

        public ZaglavljeNarudzbeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void ChangeZaglavljeNarudzbeStatus(int zaglavljeNarudzbeId, string status)
        {
            var orderFromDb = _db.ZaglavljeNarudzbe.FirstOrDefault(o => o.Id == zaglavljeNarudzbeId);
            orderFromDb.Status = status;
            _db.SaveChanges();
        }
    }
}
