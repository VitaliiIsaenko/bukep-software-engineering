using System.IO;
using Xunit;

namespace CountriesRecommendation.Helpers.Tests
{
    public class CountriesCsvReaderTests
    {
        [Fact]
        public void ReadCountries()
        {
            var onlyForTest = "../../../../countries";
            var countries = CountriesCsvReader.ReadCountries($"{onlyForTest}/Isaenko.csv");

            Assert.Equal("Венгрия", countries[0].Name);
            Assert.Equal(9_769_526, countries[0].Population);
            Assert.Equal(437, countries[0].AverageSalary);
            Assert.False(countries[0].HasSea);

            Assert.Equal("Индия", countries[1].Name);
            Assert.Equal(1_380_230_000, countries[1].Population);
            Assert.Equal(88, countries[1].AverageSalary);
            Assert.True(countries[1].HasSea);
        }
    }
}