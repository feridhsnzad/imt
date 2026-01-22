using System.Diagnostics;
using HealthCenter.Data;
using HealthCenter.Models;
using Microsoft.AspNetCore.Mvc;

namespace HealthCenter.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContex contex;

        public HomeController(AppDbContex contex)
        {
            this.contex = contex;
        }

        public IActionResult Index()
        {
           var doctors= contex.Doctors.ToList();


            return View(doctors);
        }

    }
}
