using Microsoft.AspNetCore.Mvc;

namespace CountriesRecommendationWebApp.Controllers
{
    public class HomeController : Controller
    {

        // Метод для получения страницы представления
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CountryInfo(){
            return View();
        }
    }
}