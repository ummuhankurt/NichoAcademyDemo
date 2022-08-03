using Microsoft.EntityFrameworkCore;
using NichoAcademyDemo.Model.Entities;
using NichoAcademyDemo.Model.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NichoAcademyDemo.Model.EntityFramework
{
    public class NichoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=UMMUHANKURT;Database=NichoAcademy;Trusted_Connection=true");
        }

        public DbSet<Ders> Dersler { get; set; }
        public DbSet<Hareket> Hareketler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Ogrenci> Ogrenciler { get; set; }
        public DbSet<Sinif> Siniflar { get; set; }
        public DbSet<Video> Videolar { get; set; }
        public DbSet<Kategori_Dersler> Kategori_Dersler { get; set; }
    }
}
