using Faktura_Test.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Uplift.DataAccess.Data.Repository.IRepository;
using Uplift.Models;

namespace Uplift.DataAccess.Data.Repository
{
    public class PDVRepository : Repository<PDV>, IPDVRepository
    {
        private readonly ApplicationDbContext _db;

        public PDVRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<SelectListItem> GetPDVListForDropDown()
        {
            return _db.PDV.Select(i => new SelectListItem()
            {
                Text = i.Naziv + '|' +i.Procent,
                Value = i.Id.ToString()
            });
        }

        public void Update(PDV pdv)
        {
            var objFromDb = _db.PDV.FirstOrDefault(s => s.Id == pdv.Id);

            objFromDb.Naziv = pdv.Naziv;
            objFromDb.Procent = pdv.Procent;

            _db.SaveChanges();
        }

    }
}
