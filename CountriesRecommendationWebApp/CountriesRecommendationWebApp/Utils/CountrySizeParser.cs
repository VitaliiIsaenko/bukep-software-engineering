using System;
using CountriesRecommendationWebApp.Enums;

namespace CountriesRecommendationWebApp
{
    public static class CountrySizeParser
    {
        public static CountrySize Parse(string size)
        {
            switch (size.ToLower())
            {
                case "большая":
                    return CountrySize.Big;

                case "средняя":
                    return CountrySize.Medium;

                case "малая":
                    return CountrySize.Small;

                default:
                    throw new System.Exception($"Нет значения {size} для размера страны");
            }
        }
    }
}