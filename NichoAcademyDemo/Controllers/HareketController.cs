using Microsoft.AspNetCore.Mvc;
using NichoAcademyDemo.Model.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NichoAcademyDemo.Controllers
{
    public class HareketController : Controller
    {
        public IActionResult Index()
        {
            EfHareketDal efHareketDal = new EfHareketDal();
            var data = efHareketDal.GetAll();
            return View(data);
        }
    }
}
