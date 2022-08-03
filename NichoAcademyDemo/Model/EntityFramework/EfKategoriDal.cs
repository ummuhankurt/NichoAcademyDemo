using NichoAcademyDemo.Model.Entities;
using NichoAcademyDemo.Model.Entities.Abstract;
using NichoAcademyDemo.Model.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NichoAcademyDemo.Model.EntityFramework
{
    public class EfKategoriDal : EfEntityRepositoryBase<Kategori, NichoContext>,IKategoriDal
    {
        public List<DersDetail> GetKategoriDetail()
        {
            using (NichoContext context = new NichoContext())
            {
                var result = from kd in context.Kategori_Dersler
                             join k in context.Kategoriler on kd.Kategori equals k.KategoriId
                             join d in context.Dersler on kd.Ders equals d.DersId
                             select new DersDetail { DersAdi = d.DersAdi, KategoriAd = k.KategoriAd };
                return result.ToList();

            }
        }
    }
}
