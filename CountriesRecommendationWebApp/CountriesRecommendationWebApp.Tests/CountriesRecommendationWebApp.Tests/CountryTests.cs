using CountriesRecommendationWebApp.Enums;
using CountriesRecommendationWebApp.Models;
using Xunit;

namespace CountriesRecommendationWebApp.Tests {
    public class CountryTests {
        [Fact]
        public void GetSize_PopulationLess40mil_Small() {
            // Подготовка (Arrange)
            int countryPopulation = 10_000_000;
            Country country = new Country("Test country", countryPopulation, 102, true);
            // Действие (Act)
            CountrySize result = country.GetSize();
            // Проверка (Assert)
            Assert.Equal(CountrySize.Small, result);
        }

        [Fact]
        public void GetSize_PopulationMore40Less100mil_Medium() {
            int countryPopulation = 60_000_000;
            Country country = new Country("Test country", countryPopulation, 101, true);
            CountrySize result = country.GetSize();
            Assert.Equal(CountrySize.Medium, result);
        }

        [Fact]
        public void GetSize_PopulationMore100mil_Big() {
            int countryPopulation = 111_111_111;
            Country country = new Country("Test country", countryPopulation, 100, true);
            CountrySize result = country.GetSize();
            Assert.Equal(CountrySize.Big, result);
        }
    }
}