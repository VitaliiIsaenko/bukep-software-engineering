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
            bool liveBySea = answer == "да";

            Country[] countries = CountriesCsvReader.ReadCountries("Danilov.csv");
            if (liveBySea)
            {
                if (countries[0].HasSea)
                {
                    Console.WriteLine(countries[0].Name);
                }
                if (countries[1].HasSea)
                {
                    Console.WriteLine(countries[1].Name);
                }

            }
            else
            {
                Console.WriteLine(countries[0].Name);
            }

            Console.WriteLine(liveBySea);
            
        }
    }
}