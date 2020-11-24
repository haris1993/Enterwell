using System;
using System.Collections.Generic;
using System.Text;
using Faktura_Test.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Uplift.Models;

namespace Uplift.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

       
        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<Faktura> Faktura { get; set; }
        public DbSet<Proizvod> Proizvod { get; set; }
        public DbSet<StavkeFaktura> StavkeFaktura { get; set; }
        public DbSet<DetaljiNarudzbe> DetaljiNarudzbe { get; set; }

        public DbSet<ZaglavljeNarudzbe> ZaglavljeNarudzbe { get; set; }
        public DbSet<KategorijaProizvoda> KategorijaProizvoda { get; set; }

        public DbSet<PDV> PDV { get; set; }


    }
}
