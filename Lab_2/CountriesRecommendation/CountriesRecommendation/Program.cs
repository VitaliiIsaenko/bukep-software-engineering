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

            //создаем двумерный массив, типа str и записываем в него результат выполнения 
            //CsvReader(он возвращает двумерный массив из Страны в первом массиве и информации о ней внутри этого массива)
            string[][] countriesInfo = CsvReader.Read("Isaenko.csv");
            
            //создаем массив countries типа Country(созданного мной класса Country) и задаем ему длинну равную размеру массива countriesInfo
            Country[] countries = new Country[countriesInfo.Length];

            for (int i = 0; i < countriesInfo.Length; i++) {

                string[] countryInfo = countriesInfo[i];

                countries[i] = new Country(countryInfo[0], int.Parse(countryInfo[1]), long.Parse(countryInfo[2]), countryInfo[3] == "да");

            }

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