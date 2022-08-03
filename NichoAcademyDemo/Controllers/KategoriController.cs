using Microsoft.AspNetCore.Mvc;
using NichoAcademyDemo.Model.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NichoAcademyDemo.Controllers
{
    public class KategoriController : Controller
    {
        public IActionResult Index()
        {
            EfKategoriDal efKategoriDal = new EfKategoriDal();
            var data = efKategoriDal.GetAll();
            var detail = efKategoriDal.GetKategoriDetail();
            return View(detail);
        }
    }
}
