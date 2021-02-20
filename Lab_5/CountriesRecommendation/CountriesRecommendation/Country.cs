public class Country {

    public Country(string CountryName, long CountryPopulations, int CountryAverageSalary, bool CountryHasSea) {
        Name = CountryName;
        Populations = CountryPopulations;
        AverageSalary = CountryAverageSalary;
        HasSea = CountryHasSea;
    }

    public long Populations; 
    public int AverageSalary;
    public bool HasSea {get;}
    public string Name {get;}
}