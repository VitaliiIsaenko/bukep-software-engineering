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

            Console.WriteLine(liveBySea);

            Country[] countries = CountriesCsvReader.ReadCountries("Krekshin.csv");

            if (liveBySea) {
                if (countries[0].HasSea) {
                    Console.WriteLine(countries[0].ToString());
                } else if (countries[1].HasSea) {
                    Console.WriteLine(countries[1].ToString());
                }
            } else {
                Console.WriteLine(countries[1].ToString());
            }
        }
    }
}