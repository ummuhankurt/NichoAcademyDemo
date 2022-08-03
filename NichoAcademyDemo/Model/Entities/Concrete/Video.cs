using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NichoAcademyDemo.Model.Entities.Concrete
{
    public class Video : IEntity
    {
        public short VideoId { get; set; }
        public string Ders { get; set; }
        public string Url { get; set; }
    }
}
