public class Country
{
    private long population;
    private long averageSalary;

    public bool HasSea{get;}

    public string Name{get;}

    public Country(string countryName, long countryAverageSalary, long countryPopulation, bool countryHasSea)
    {
        Name = countryName;
        averageSalary = countryAverageSalary;
        population = countryPopulation;
        HasSea = countryHasSea;
    }

}
