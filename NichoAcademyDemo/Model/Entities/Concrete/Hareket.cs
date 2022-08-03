using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NichoAcademyDemo.Model.Entities.Concrete
{
    public class Hareket : IEntity
    {
        public int HareketId { get; set; }
        public int Ders { get; set; }
        public int Ogrenci { get; set; }
        public short Video { get; set; }
    }
}
