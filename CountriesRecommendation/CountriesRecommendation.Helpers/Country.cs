namespace CountriesRecommendation.Helpers
{
    public class Country
    {
        public Country(string name, long population, int averageSalary, bool hasSea)
        {
            Name = name;
            Population = population;
            AverageSalary = averageSalary;
            HasSea = hasSea;
        }

        public string Name { get; set; }
        public long Population { get; set; }
        public int AverageSalary { get; set; }
        public bool HasSea { get; set; }

        public override string ToString()
        {
            var description = $"Страна {Name} с населением {Population}, средней зарплатой {AverageSalary}$. ";
            if (HasSea)
            {
                description += "Имеет выход к морю";
            }
            else
            {
                description += "Не имеет выхода к морю";
            }

            return description;
        }
    }
}