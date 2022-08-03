using Microsoft.AspNetCore.Mvc;
using NichoAcademyDemo.Model.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NichoAcademyDemo.Controllers
{
    public class VideoController : Controller
    {
        public IActionResult Index()
        {
            EfVideoDal efVideoDal = new EfVideoDal();
            var data = efVideoDal.GetAll();
            return View(data);
        }
    }
}
