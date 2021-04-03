using CountriesRecommendation.Helpers;
using CountriesRecommendationWebApp.Enums;
using CountriesRecommendationWebApp.Models;
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

        [HttpPost]
        public IActionResult CountryInfo(bool liveBySea, int minSalary, CountrySize size)
        {
            // На основе полученных параметров формируем объект типа UserPreferences
            UserPreferences userPreferences = new UserPreferences(liveBySea, minSalary, size);

            // Считываем данные о странах в виде массивов строк
            string[][] countriesStrings = CsvReader.Read(new string[] {"Homchenko.csv"});
            Country[] countries = new Country[countriesStrings.Length];

            // Каждую строку массива преобразуем в объект и заполняем объектами массив countries
            for (int i = 0; i < countriesStrings.Length; i++) {
                string[] countryString = countriesStrings[i];
                countries[i] = new Country(countryString[0], long.Parse(countryString[1]),
                int.Parse(countryString[2]), countryString[3] == "да");
            }

            // Определяем переменную, в которой будем хранить выбранную страну
            Country foundCountry = null;

            // В цикле ищем страну, удовлетворяющую предпочтениям пользователя
            foreach (Country country in countries) {
                if (userPreferences.Satisfied(country)) {
                    foundCountry = country;
                }
            }

            // Возвращаем в ответ объект представления, куда передаем переменную с выбранной страной 
            return View(foundCountry);
        }
    }
}