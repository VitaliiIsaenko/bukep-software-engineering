public class Country {
    private string name;
    private int averageSalary;
    private long population;
    public bool HasSea {get;set;}
    
    public Country(string countryName, int countryAverageSalary, long countryPopulation, bool countryHasSea) {
        name = countryName;
        averageSalary = countryAverageSalary;
        population = countryPopulation;
        HasSea = countryHasSea;
    }

}