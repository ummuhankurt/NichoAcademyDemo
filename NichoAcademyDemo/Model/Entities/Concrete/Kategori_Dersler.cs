using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NichoAcademyDemo.Model.Entities.Concrete
{
    public class Kategori_Dersler : IEntity
    {
        public int Id { get; set; }
        public short Kategori { get; set; }
        public int Ders { get; set; }
    }
}
