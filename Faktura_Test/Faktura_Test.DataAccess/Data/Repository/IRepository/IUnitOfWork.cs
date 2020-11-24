using System;
using System.Collections.Generic;
using System.Text;

namespace Uplift.DataAccess.Data.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
       
        IUserRepository UserRepository { get; }

        IProizvodRepository ProizvodRepository { get; }
        IFakturaRepository FakturaRepository { get; }
        IStavkeFakturaRepository StavkeFakturaRepository { get; }
        IZaglavljeNarudzbeRepository ZaglavljeNarudzbeRepository { get; }
        IDetaljiNarudzbeRepository DetaljiNarudzbeRepository { get; }
        IKategorijaProizvodaRepository KategorijaProizvodaRepository { get; }
        IPDVRepository PDVRepository { get; }




        void Save();
    }
}
