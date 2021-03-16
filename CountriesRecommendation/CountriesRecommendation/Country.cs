namespace CountriesRecommendation
{
    public class Country
    {
        public string Name { get; }
        public int AverageSalary { get; }
        private long population;
        public bool HasSea { get; }

        public Country(string countryName, long countryPopulation, int countryAverageSalary, bool countryHasSea)
        {
            Name = countryName;
            population = countryPopulation;
            AverageSalary = countryAverageSalary;
            HasSea = countryHasSea;
        }
        public CountrySize GetSize()
        {
            if (population <= 40_000_000)
            {
                return CountrySize.Small;
            }
            else if (40_000_000 < population && population < 100_000_000)
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