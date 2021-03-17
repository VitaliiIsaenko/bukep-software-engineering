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

            Country[] countries = CountriesCsvReader.ReadCountries("Homchenko.csv");

            if (liveBySea)
            {
                if (countries[0].HasSea){
                
                    Console.WriteLine(countries[0]);
                }
                else {
                    Console.WriteLine(countries[1]);
                }
            }
            else
            {
                Console.WriteLine(countries[0]);
            }
        }
    }
}