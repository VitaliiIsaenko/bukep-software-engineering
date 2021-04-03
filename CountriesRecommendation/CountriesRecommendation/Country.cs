public class Country
{
    private long population;
    public long averageSalary;

    public bool HasSea{get;}

    public string Name{get;}

    public Country(string countryName, long countryPopulation, long countryAverageSalary, bool countryHasSea)
    {
        Name = countryName;
        population = countryPopulation;
        averageSalary = countryAverageSalary;
        HasSea = countryHasSea;
    }

}
