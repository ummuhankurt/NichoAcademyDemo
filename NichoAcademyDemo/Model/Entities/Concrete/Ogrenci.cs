using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NichoAcademyDemo.Model.Entities.Concrete
{
    public class Ogrenci : IEntity
    {
        public int OgrenciId { get; set; }
        public short Sinif { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Email { get; set; }
    }
}
