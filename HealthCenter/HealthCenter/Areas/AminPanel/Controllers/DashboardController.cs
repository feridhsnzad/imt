using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace HealthCenter.Areas.AminPanel.Controllers
{
    [Area("AdminPanel")]
    public class DashboardController:Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
