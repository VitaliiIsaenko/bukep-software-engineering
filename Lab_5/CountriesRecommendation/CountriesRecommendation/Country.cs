namespace CountriesRecommendation {
    public class Country {
        public string Name {get;}
        public int AverageSalary {get;}
        private long population {get;} 
        public bool HasSea {get;}

        public Country(string countryName, long countryPopulation, int countryAverageSalary, bool countryHasSea) {
            Name = countryName;
            AverageSalary = countryAverageSalary;
            population = countryPopulation;
            HasSea = countryHasSea;
        }

        public CountrySize GetSize() {
            if (this.population <= 40_000_000) {
                return CountrySize.Small;
            }

            else if (40_000_000 < this.population && this.population < 100_000_000) {
                return CountrySize.Medium;
            }

            else {
                return CountrySize.Big;
            }
        }
    }
}