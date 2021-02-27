using CountriesRecommendationWebApp.Enums;

namespace CountriesRecommendationWebApp.Models
{
    public class Country
    {
        public string Name { get; }
        public int AverageSalary { get; }
        public long Population {get;}
        public bool HasSea { get; }

        public Country(string countryName, long countryPopulation, int countryAverageSalary, bool countryHasSea)
        {
            Name = countryName;
            Population = countryPopulation;
            AverageSalary = countryAverageSalary;
            HasSea = countryHasSea;
        }

        public CountrySize GetSize()
        {
            if (Population <= 40_000_000)
            {
                return CountrySize.Small;
            }
            else if (40_000_000 < Population && Population < 100_000_000)
            {
                return CountrySize.Medium;
            }
            else
            {
                return CountrySize.Big;
            }
        }
    }
}