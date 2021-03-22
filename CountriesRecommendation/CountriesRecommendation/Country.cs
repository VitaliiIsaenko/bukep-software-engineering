public class Country {
    private long population;
    private int averageSalary;
    public bool HasSea;
    public string Name;

    public Country(string countryName, int countryAverageSalary, long countryPopulation, bool countryHasSea) {
        population = countryPopulation;
        averageSalary = countryAverageSalary;
        HasSea = countryHasSea;
        Name = countryName;
    }
}