using NichoAcademyDemo.Model.Entities.Abstract;
using NichoAcademyDemo.Model.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NichoAcademyDemo.Model.EntityFramework
{
    public class EfSinifDal : EfEntityRepositoryBase<Sinif,NichoContext> , ISinifDal
    {

    }
}
