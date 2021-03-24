public class UserPreferences
{
    public bool liveBySea;
    public int minSalary;
    public string size;
    public bool Statisfied(Country country)
    {
        if (liveBySea)
        {
            if (country.HasSea)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        else
        {
            return true;
        }
    }
    public void SetLiveBySea(bool liveBySea)
    {
        this.liveBySea = liveBySea;
    }
}