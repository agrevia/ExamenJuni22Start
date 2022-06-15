using JurassicWorld.Domain.Repositories;
using JurassicWorld.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace JurassicWorld.Web.Controllers
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
        //Schrijf je code hier
        //ShowDinos



        //ShowAttractions
       
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}