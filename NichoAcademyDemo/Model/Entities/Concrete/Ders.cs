using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NichoAcademyDemo.Model.Entities
{
    public class Ders : IEntity
    {
        public int DersId { get; set; }
        public string DersAdi { get; set; }
    }
}
