using NichoAcademyDemo.Model.Entities.Concrete;
using NichoAcademyDemo.Model.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NichoAcademyDemo.Model.Entities.Abstract
{
    public interface IOgrenciDal : IEntityRepository<Ogrenci>
    {

    }
}
