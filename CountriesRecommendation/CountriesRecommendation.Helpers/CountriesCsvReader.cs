using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CountriesRecommendation.Helpers
{
    public class CountriesCsvReader
    {
        public static Country[] ReadCountries(string fileName)
        {
            var curr = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;
            var filePath = $"{curr}/countries/{fileName}";

            Country[] countries = new Country[10];

            var lines = File.ReadAllLines(filePath).Skip(1).ToArray();

            for(int i = 0; i < lines.Length; i++) {
                
                var fields = lines[i].Split(",");

                var country = new Country(fields[0], long.Parse(fields[1]), int.Parse(fields[2]), fields[3] == "да");

                countries[i] = country;

            }
            return countries;
        }
    }
}