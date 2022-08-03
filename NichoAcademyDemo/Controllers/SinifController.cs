using Microsoft.AspNetCore.Mvc;
using NichoAcademyDemo.Model.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NichoAcademyDemo.Controllers
{
    public class SinifController : Controller
    {
        public IActionResult Index()
        {
            EfSinifDal efSinifDal = new EfSinifDal();
            var data = efSinifDal.GetAll();
            return View(data);
        }
    }
}
