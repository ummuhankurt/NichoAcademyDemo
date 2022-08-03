using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NichoAcademyDemo.Model.Entities.Concrete
{
    public class Kategori : IEntity
    {
        public short KategoriId { get; set; }
        public string KategoriAd { get; set; }
    }
}
