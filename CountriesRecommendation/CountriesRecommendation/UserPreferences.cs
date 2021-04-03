public class UserPreferences
{
    public bool liveBySea;
    public int minSalary;
    public string size;
    public bool Statisfied(Country country)
    {
        if(LiveBySeaSatisfied(country) && MinSalaryStatisfied(country))
        {
            return true;
        }

        else
        {
            return false;
        }
    }
    private bool LiveBySeaSatisfied(Country country) 
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

    public bool MinSalaryStatisfied(Country country)
    {
        if (country.averageSalary >= minSalary)
        {
            return true;
        }

        else
        {
            return false;
        }
    }

    public void SetMinSalary(int minSalary)
    {
        if (minSalary > 0)
        {
            this.minSalary = minSalary;
        }

        else
        {
            throw new System.Exception("Минимальная зарплата должна быть больше 0");
        }
    }
}