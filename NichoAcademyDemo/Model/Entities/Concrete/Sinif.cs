using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NichoAcademyDemo.Model.Entities.Concrete
{
    public class Sinif : IEntity
    {
        public short SinifId { get; set; }
        public string SinifAd { get; set; }
        public int Ders { get; set; }

    }
}
