public class Country {
    public string Name {get;}
    private int averageSalary;
    private long population;
    public bool HasSea {get;}
    
    public Country(string countryName, int countryAverageSalary, long countryPopulation, bool countryHasSea) {
        Name = countryName;
        averageSalary = countryAverageSalary;
        population = countryPopulation;
        HasSea = countryHasSea;
    }

}