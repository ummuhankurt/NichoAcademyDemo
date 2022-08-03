using Microsoft.AspNetCore.Mvc;
using NichoAcademyDemo.Model.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NichoAcademyDemo.Controllers
{
    public class DersController : Controller
    {
        public IActionResult Index()
        {
            EfDersDal efDersDal = new EfDersDal();
            var data = efDersDal.GetAll();
            return View(data);
        }
    }
}
