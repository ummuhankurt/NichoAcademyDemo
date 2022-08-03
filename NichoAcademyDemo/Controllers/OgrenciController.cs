using Microsoft.AspNetCore.Mvc;
using NichoAcademyDemo.Model.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NichoAcademyDemo.Controllers
{
    public class OgrenciController : Controller
    {
        public IActionResult Index()
        {
            EfOgrenciDal efOgrenciDal = new EfOgrenciDal();
            var data = efOgrenciDal.GetAll();
            return View(data);
        }
    }
}
