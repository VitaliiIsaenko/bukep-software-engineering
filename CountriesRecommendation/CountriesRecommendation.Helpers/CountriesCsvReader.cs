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
            List<Country> countries = new List<Country>();
            var lines = File.ReadAllLines(filePath).Skip(1).ToArray();
            foreach(var line in lines) {
                var fields = line.Split(",");
                var country = new Country(fields[0], long.Parse(fields[1]), int.Parse(fields[2]), fields[3] == "да");
                countries.Add(country);
            }
            return countries.ToArray();
        }
    }
}