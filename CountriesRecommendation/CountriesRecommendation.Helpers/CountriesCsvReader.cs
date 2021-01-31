using System;
using System.Collections.Generic;

namespace CountriesRecommendation.Helpers
{
    public class CountriesCsvReader
    {
        public List<Country> ReadCountries(string filePath)
        {
            return new List<Country>()
            {
                new Country()
                {
                    Name = "Венгрия"
                }
            };
        }
    }
}