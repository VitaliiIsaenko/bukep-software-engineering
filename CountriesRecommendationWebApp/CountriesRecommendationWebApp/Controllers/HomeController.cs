using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CountriesRecommendationWebApp.Models;
using CountriesRecommendation.Helpers;
using Microsoft.AspNetCore.Routing;
using CountriesRecommendationWebApp.Enums;

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

        // Метод для поиска страны на основе предпочтений пользователя
        [HttpPost]
        public IActionResult ChosenCountry(bool liveBySea, int minSalary, CountrySize size)
        {
            UserPreferences userPreferences = new UserPreferences(liveBySea, minSalary, size);

            string[][] countriesStrings = CsvReader.Read(new string[] {"Isaenko.csv"});

            // Преобразуем строки с информацией о странах в объекты стран
            List<Country> countries = countriesStrings.Select(cs => new Country(cs[0], long.Parse(cs[1]), int.Parse(cs[2]), cs[3] == "да")).ToList();
            Country country = countries.FirstOrDefault(c => userPreferences.Satisfied(c));

            return View(country);
        }
    }
}