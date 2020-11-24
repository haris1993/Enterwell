using System;
using System.Collections.Generic;
using System.Text;
using Uplift.Models;

namespace Uplift.DataAccess.Data.Repository.IRepository
{
    public interface IZaglavljeNarudzbeRepository : IRepository<ZaglavljeNarudzbe>
    {
        public void ChangeZaglavljeNarudzbeStatus(int zaglavljeNarudzbeId, string status);
    }
}
