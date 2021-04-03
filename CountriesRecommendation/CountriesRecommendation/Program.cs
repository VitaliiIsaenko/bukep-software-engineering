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

            liveBySea = answer == "Да";

            UserPreferences preferences = new UserPreferences();
            preferences.SetLiveBySea(liveBySea);

            Console.WriteLine("Сколько вы хотите зарабатывать?");
            preferences.SetMinSalary(int.Parse(Console.ReadLine()));

            string[][] countriesInfo = CsvReader.Read("Samokhlebov.csv");
            Country[] countries = new Country[countriesInfo.Length];
            for(int i = 0; i < countriesInfo.Length; i++)
            {
                string[] countryInfo = countriesInfo[i];
                countries[i] = new Country(countryInfo[0], int.Parse(countryInfo[1]), long.Parse(countryInfo[2]), countryInfo[3] == "да");
            }

            foreach(Country country in countries)
            {
                if (preferences.Statisfied(country))
                {
                    Console.WriteLine(country.Name);
                    return;
                }
            }
            Console.WriteLine("Извините, мы не смогли подобрать страну с такими параметрами");
        
        }
    }
}