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

            Country[] countries = CountriesCsvReader.ReadCountries("Shepelev.csv");
            //Если пользователь предпочитаеть жить у моря
            if (liveBySea == true) {
                //если первая страна в списке имеет выход к морю 
                if(countries[0].HasSea){
                    Console.WriteLine (countries[0].Name);
                } else
                //если вторая страна в списке имеет выход к морю
                if (countries[1].HasSea) {
                    Console.WriteLine (countries[1].Name);
                }
            } 
            //В противном случае (иначе) выведите любую страну в консоль
            else {
            Console.WriteLine (countries[1].Name);
                
            }
        }
    }
}                                                                                                                                                                                                   