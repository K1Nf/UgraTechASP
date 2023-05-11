using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using UgraTech.Models;

namespace UgraTech.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Project_1()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Lab_1_dol()
        {
            return View();
        }        
    }
}