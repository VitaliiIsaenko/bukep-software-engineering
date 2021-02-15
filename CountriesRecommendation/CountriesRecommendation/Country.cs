public class Country {
    public string Name {get;}
    public int AverageSalary {get;}
    private long population;
    public bool HasSea {get;}
    
    public Country(string countryName, int countryAverageSalary, long countryPopulation, bool countryHasSea) {
        Name = countryName;
        AverageSalary = countryAverageSalary;
        population = countryPopulation;
        HasSea = countryHasSea;
    }
}