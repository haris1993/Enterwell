using System;
using System.Collections.Generic;
using System.Text;
using Uplift.DataAccess.Data.Repository.IRepository;
using Uplift.Models;

namespace Uplift.DataAccess.Data.Repository
{
    public class DetaljiNarudzbeRepository : Repository<DetaljiNarudzbe>, IDetaljiNarudzbeRepository
    {
        private readonly ApplicationDbContext _db;

        public DetaljiNarudzbeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


    }
}
