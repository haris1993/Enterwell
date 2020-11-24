using System;
using System.Collections.Generic;
using System.Text;
using Uplift.DataAccess.Data.Repository.IRepository;

namespace Uplift.DataAccess.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;

            UserRepository = new UserRepository(_db);
            ProizvodRepository = new ProizvodRepository(_db);
            FakturaRepository = new FakturaRepository(_db);
            StavkeFakturaRepository = new StavkeFakturaRepository(_db);
            ZaglavljeNarudzbeRepository = new ZaglavljeNarudzbeRepository(_db);
            DetaljiNarudzbeRepository = new DetaljiNarudzbeRepository(_db);
            DetaljiNarudzbeRepository = new DetaljiNarudzbeRepository(_db);
            KategorijaProizvodaRepository = new KategorijaProizvodaRepository(_db);
            PDVRepository = new PDVRepository(_db);




        }


        public IUserRepository UserRepository { get; private set; }
        public IProizvodRepository ProizvodRepository { get; private set; }
        public IFakturaRepository FakturaRepository { get; private set; }
        public IStavkeFakturaRepository StavkeFakturaRepository { get; private set; }
        public IDetaljiNarudzbeRepository DetaljiNarudzbeRepository { get; private set; }
        public IZaglavljeNarudzbeRepository ZaglavljeNarudzbeRepository { get; private set; }
        public IKategorijaProizvodaRepository KategorijaProizvodaRepository { get; private set; }
        public IPDVRepository PDVRepository { get; private set; }










        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
