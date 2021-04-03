using CountriesRecommendationWebApp.Enums;
using CountriesRecommendationWebApp.Models;
using Xunit;

namespace CountriesRecommendationWebApp.Tests {
    public class UserPreferencesTests {
        [Fact]
        public void LiveBySeaSatisfied_PreferenceLiveBySeaCountryWithSea_True() {
            // Подготовка (Arrange)
            UserPreferences userPreferences = new UserPreferences(true, 1000, CountrySize.Small);
            Country country = new Country("Test country", 10_000_000, 101, true);
            // Действие (Act)
            bool result = userPreferences.LiveBySeaSatisfied(country);
            // Проверка (Assert)
            Assert.True(result);
        }

        [Fact]
        public void LiveBySeaSatisfied_PreferenceNotLiveBySeaCountryWithSea_True() {
            UserPreferences userPreferences = new UserPreferences(false, 1000, CountrySize.Small);
            Country country = new Country("Test country", 10_000_000, 101, true);

            bool result = userPreferences.LiveBySeaSatisfied(country);

            Assert.True(result);
        }

        [Fact]
        public void LiveBySeaSatisfied_PreferenceNotLiveBySeaCountryWithoutSea_True() {
            UserPreferences userPreferences = new UserPreferences(false, 1000, CountrySize.Small);
            Country country = new Country("Test country", 10_000_000, 101, false);

            bool result = userPreferences.LiveBySeaSatisfied(country);

            Assert.True(result);
        }

        [Fact]
        public void LiveBySeaSatisfied_PreferenceLiveBySeaCountryWithSea_False() {
            UserPreferences userPreferences = new UserPreferences(true, 1000, CountrySize.Small);
            Country country = new Country("Test country", 10_000_000, 101, false);

            bool result = userPreferences.LiveBySeaSatisfied(country);

            Assert.False(result);
        }

        [Fact]
        public void SizeSatisfied_PreferencesSizeSmallCountrySizeSmall_True() {
            UserPreferences userPreferences = new UserPreferences(true, 1000, CountrySize.Small);
            Country country = new Country("Test country", 10_000_000, 101, false);
            
            bool result = userPreferences.SizeSatisfied(country);

            Assert.True(result);
        }

        [Fact]
        public void SizeSatisfied_PreferencesSizeBigCountrySizeSmall_False() {
            UserPreferences userPreferences = new UserPreferences(true, 1000, CountrySize.Big);
            Country country = new Country("Test country", 10_000_000, 101, false);
            
            bool result = userPreferences.SizeSatisfied(country);

            Assert.False(result);
        }

        [Fact]
        public void MinSalarySatisfied_PreferencesSalary250CountryAverageSalary400_True() {
            UserPreferences userPreferences = new UserPreferences(true, 250, CountrySize.Small);
            Country country = new Country("Test country", 10_000_000, 400, false);
            
            bool result = userPreferences.MinSalarySatisfied(country);

            Assert.True(result);
        }

        [Fact]
        public void MinSalarySatisfied_PreferencesSalary3500CountryAverageSalary400_False() {
            UserPreferences userPreferences = new UserPreferences(true, 3500, CountrySize.Small);
            Country country = new Country("Test country", 10_000_000, 400, false);
            
            bool result = userPreferences.MinSalarySatisfied(country);

            Assert.False(result);
        }

        [Fact]
        public void Satisfied_PreferencesWithSeaMinSalary2000SizeMediumCountryHasSeaCountryAverageSlary4000CountrySizeSmall_True() {
            UserPreferences userPreferences = new UserPreferences(true, 2000, CountrySize.Small);
            Country country = new Country("Test country", 10_000_000, 4000, true);
            
            bool result = userPreferences.Satisfied(country);

            Assert.True(result);
        }

        [Fact]
        public void Satisfied_PreferencesWithSeaMinSalary4000SizeMediumCountryHasSeaCountryAverageSlary2000CountrySizeSmall_False() {
            UserPreferences userPreferences = new UserPreferences(true, 4000, CountrySize.Small);
            Country country = new Country("Test country", 10_000_000, 2000, true);
            
            bool result = userPreferences.Satisfied(country);

            Assert.False(result);
        }
    }
}