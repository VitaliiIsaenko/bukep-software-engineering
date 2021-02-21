namespace CountriesRecommendation
{
    public class CountrySizeParse
    {
        public static CountrySize ParseCountrySize(string size) {
            switch (size) {
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