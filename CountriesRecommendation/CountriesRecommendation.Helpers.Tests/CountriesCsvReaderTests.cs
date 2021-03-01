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
            var countries = CsvReader.Read($"{onlyForTest}/Isaenko.csv");

            Assert.Equal(2, countries.Length);

            Assert.Equal("Венгрия", countries[0][0]);
            Assert.Equal(9_769_526, long.Parse(countries[0][1]));
            Assert.Equal(437, int.Parse(countries[0][2]));
            Assert.False(countries[0][3] == "да");

            Assert.Equal("Индия", countries[1][0]);
            Assert.Equal(1_380_230_000, long.Parse(countries[1][1]));
            Assert.Equal(88, int.Parse(countries[1][2]));
            Assert.True(countries[1][3]=="да");
        }
    }
}