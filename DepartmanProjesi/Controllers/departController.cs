﻿using Microsoft.AspNetCore.Mvc;
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
        [HttpGet]
        public IActionResult YeniDepartman()
        {
            return View();
        }
        [HttpPost]
        public IActionResult YeniDepartman(departmanlar d)
        {

            return View();
        }
    }
}
