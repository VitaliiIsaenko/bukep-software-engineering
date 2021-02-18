// Дизайнер является человеком
public class Designer : Person
{
    public Portfolio portfolio;
    public override string GetName() {
        return "Дизайнер " + name;
    }

    public string GetFullPortfolioName() {
        portfolio = new Portfolio();
        return portfolio.GetFullName();
    }
}