using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Training.Models;

namespace Training.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public string GetDay(int n)
        {
       
            switch(n)
            {
                    case 1:
                    return "Monday";    
                    case 2:
                    return "Tuesday";
                    case 3:
                    return "Wednesday"; 
                    case 4:
                    return "Thursday";
                    case 5:
                    return "Friday";
                    case 6:
                    return "Saturday";
                    case 7:
                    return "Sunday";
                    default:
                    return "Error";
            }

        }
        public IActionResult FirstView()
        {
            
            
            return View();
        }
    }
}
