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

            Console.WriteLine("Сколько вы хотите зарабатывать?");
            int UserSalary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("В какой по размеру стране вы хотите жить?\n Введите ответ: 'большая', 'средняя', 'малая'.");
            CountrySize SizeCountry = CountrySizeParse.ParseCountrySize(Console.ReadLine());

            UserPreferences preferences = new UserPreferences();
            preferences.SetLiveBySea(liveBySea); //передаем в UserPreferences информацию о море
            preferences.SetMinSalary(UserSalary); //передаем в UserPreferences информацию о мин. ЗП
            preferences.SetSize(SizeCountry); //передаем в UserPreferences информацию о размере страны

            //создаем зубчатый массив, типа str и записываем в него результат выполнения 
            //CsvReader(он возвращает зубчатый массив из Страны в первом массиве и информации о ней внутри этого массива)
            string[][] countriesInfo = CsvReader.Read(new string[] {"Krekshin.csv", "Isaenko.csv"});
            
            //создаем массив countries типа Country(созданного мной класса Country) и задаем ему длинну равную размеру массива countriesInfo
            Country[] countries = new Country[countriesInfo.Length];
            
            for (int i = 0; i < countriesInfo.Length; i++) {
                
                //создаем строковый массив countryInfo и передаем в него информацию о стране из countriesInfo
                string[] countryInfo = countriesInfo[i];

                //в массив countries с помощью конструктора передаем информацию о странах
                countries[i] = new Country(countryInfo[0], long.Parse(countryInfo[1]), int.Parse(countryInfo[2]), countryInfo[3] == "да");
            }
            
            foreach (Country country in countries) {
                if (preferences.Satisfied(country)) {
                    Console.WriteLine(country.Name);
                    return;
                }
            }
            Console.WriteLine("Извините, мы не смогли подобрать страну с такими параметрами");
        }
    }
}