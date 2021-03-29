using CountriesRecommendationWebApp.Enums;
using CountriesRecommendationWebApp.Models;
using Xunit;

namespace CountriesRecommendationWebApp.Tests {
    public class UserPreferencesTests {
        [Fact]
        public void LiveBySeaSatisfied_PreferenceLiveBySeaCountryWithSea_True() {
            // Подготовка (Arrange)
            UserPreferences userPreferences = new UserPreferences(true, 1000, CountrySize.Small);
            Country country = new Country("Test country", 10_000_000, 10, true);
            // Действие (Act)
            bool result = userPreferences.LiveBySeaSatisfied(country);
            // Проверка (Assert)
            Assert.True(result);
        }

        [Fact]
        public void LiveBySeaSatisfied_PreferenceNotLiveBySeaCountryWithSea_True() {
            UserPreferences userPreferences = new UserPreferences(false, 1000, CountrySize.Small);
            Country country = new Country("Test country", 10_000_000, 10, true);

            bool result = userPreferences.LiveBySeaSatisfied(country);

            Assert.True(result);
        }

        [Fact]
        public void LiveBySeaSatisfied_PreferenceNotLiveBySeaCountryWithoutSea_True() {
            UserPreferences userPreferences = new UserPreferences(false, 1000, CountrySize.Small);
            Country country = new Country("Test country", 10_000_000, 10, false);

            bool result = userPreferences.LiveBySeaSatisfied(country);

            Assert.True(result);
        }

        [Fact]
        public void LiveBySeaSatisfied_PreferenceLiveBySeaCountryWithSea_False() {
            UserPreferences userPreferences = new UserPreferences(true, 1000, CountrySize.Small);
            Country country = new Country("Test country", 10_000_000, 10, false);

            bool result = userPreferences.LiveBySeaSatisfied(country);

            Assert.False(result);
        }

        [Fact]
        public void SizeSatisfied_PreferencesSizeSmallCountrySizeSmall_True() {
            UserPreferences userPreferences = new UserPreferences(true, 1000, CountrySize.Small);
            Country country = new Country("Test country", 10_000_000, 10, false);
            
            bool result = userPreferences.SizeSatisfied(country);

            Assert.True(result);
        }

        [Fact]
        public void SizeSatisfied_PreferencesSizeBigCountrySizeSmall_False() {
            UserPreferences userPreferences = new UserPreferences(true, 1000, CountrySize.Big);
            Country country = new Country("Test country", 10_000_000, 10, false);
            
            bool result = userPreferences.SizeSatisfied(country);

            Assert.False(result);
        }

        [Fact]
        public void MinSalarySatisfied_PreferencesSalary4000CountryAverageSalary5000_True() {
            UserPreferences userPreferences = new UserPreferences(true, 4000, CountrySize.Small);
            Country country = new Country("Test country", 10_000_000, 5000, false);
            
            bool result = userPreferences.MinSalarySatisfied(country);

            Assert.True(result);
        }

        [Fact]
        public void MinSalarySatisfied_PreferencesSalary5000CountryAverageSalary10_True() {
            UserPreferences userPreferences = new UserPreferences(true, 5000, CountrySize.Small);
            Country country = new Country("Test country", 10_000_000, 10, false);
            
            bool result = userPreferences.MinSalarySatisfied(country);

            Assert.False(result);
        }

        [Fact]
        public void Satisfied_PreferencesWithSeaPreferencesMinSalary4000PreferencesSizeMediumCountryHasSeaCountryAverageSlary5000CountrySizeMedium_True() {
            UserPreferences userPreferences = new UserPreferences(true, 4000, CountrySize.Medium);
            Country country = new Country("Test country", 50_000_000, 5000, true);
            
            bool result = userPreferences.Satisfied(country);

            Assert.True(result);
        }

        [Fact]
        //Изменена только ЗП
        public void Satisfied_PreferencesWithSeaPreferencesMinSalary7000PreferencesSizeMediumCountryHasSeaCountryAverageSlary5000CountrySizeMedium_False() {
            UserPreferences userPreferences = new UserPreferences(true, 7000, CountrySize.Medium);
            Country country = new Country("Test country", 50_000_000, 5000, true);
            
            bool result = userPreferences.Satisfied(country);

            Assert.False(result);
        }
    }
}