using Microsoft.AspNetCore.Mvc;
using DepartmanProjesi.Models;
namespace DepartmanProjesi.Controllers
{
    public class departController : Controller
    {
        Context c = new Context();
        public IActionResult Index()
        {
            var degerler = c.departmanlars.ToList();
            return View(degerler);
        }
    }
}
