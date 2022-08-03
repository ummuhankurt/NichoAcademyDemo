using NichoAcademyDemo.Model.Entities.Abstract;
using NichoAcademyDemo.Model.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NichoAcademyDemo.Model.Entities.Concrete
{
    public class EfDersDal : EfEntityRepositoryBase<Ders,NichoContext>,IDersDal
    {

    }
}
