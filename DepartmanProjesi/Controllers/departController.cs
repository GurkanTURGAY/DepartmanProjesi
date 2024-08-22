using Microsoft.AspNetCore.Mvc;

namespace DepartmanProjesi.Controllers
{
    public class departController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
