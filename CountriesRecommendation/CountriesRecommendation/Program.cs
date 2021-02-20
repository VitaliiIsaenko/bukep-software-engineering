using System;
using CountriesRecommendation.Helpers;

namespace CountriesRecommendation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Хотите ли вы жить у моря?");
            string answer = Console.ReadLine();
            bool liveBySea;

            liveBySea = answer == "да";

            UserPreferences preferences = new UserPreferences();
            preferences.SetLiveBySea(liveBySea);

            Console.WriteLine("Сколько вы хотите зарабатывать?");
            preferences.SetMinSalary(int.Parse(Console.ReadLine()));

            Console.WriteLine("Какая страна должна быть по размеру?");
            preferences.SetSize(ParseCountrySize(Console.ReadLine()));
            
            //todo: didn't explain it yet - change in the end of the lab! (explaining overloading)
            string[][] countriesInfo = CsvReader.Read(new string[]{"Isaenko.csv","Krekshin.csv"});
            Country[] countries = new Country[countriesInfo.Length];
            for (int i = 0; i < countriesInfo.Length; i++)
            {
                string[] countryInfo = countriesInfo[i];
                countries[i] = new Country(countryInfo[0], long.Parse(countryInfo[1]), int.Parse(countryInfo[2]), countryInfo[3] == "да");
            }

            foreach (Country country in countries)
            {
                if (preferences.Satisfied(country))
                {
                    Console.WriteLine(country.Name);
                    return;
                }
            }
            Console.WriteLine("Извините, мы не смогли подобрать страну с такими параметрами");
        }

        private static CountrySize ParseCountrySize(string countrySize) {
            switch (countrySize)
            {
                case "большая":
                    return CountrySize.Big;
                case "средняя":
                    return CountrySize.Medium;
                case "малая":
                    return CountrySize.Small;
                default:
                    throw new Exception($"Нет значения {countrySize} для размера страны");
            }
        }
    }
}