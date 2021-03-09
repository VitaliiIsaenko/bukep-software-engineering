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



            Country[] countries = CountriesCsvReader.ReadCountries("Isaenko.csv");
            if (answer == "да")
            {
                if (countries[0].HasSea == true)
                {
                    Console.WriteLine(countries[0].ToString());
                }
                else
                {
                Console.WriteLine(countries[1].ToString());
                }
            }
            else
            {
                if (countries[0].HasSea == false)
                {
                    Console.WriteLine(countries[0].ToString());
                }
                else
                {
                Console.WriteLine(countries[1].ToString());
                }
            }
        }
    }
}