public class Country {

    public Country(string CountryName, long CountryPopulations, int CountryAverageSalary, bool CountryHasSea) {
        Name = CountryName;
        Populations = CountryPopulations;
        AverageSalary = CountryAverageSalary;
        HasSea = CountryHasSea;
    }

    private long Populations; 
    private int AverageSalary;
    public bool HasSea {get;}
    public string Name {get;}
}