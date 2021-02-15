using System;

public class UserPreferences
{
    public bool Satisfied(Country country)
    {
        return LiveBySeaSatisfied(country) && MinSalarySatisfied(country);
    }
    private bool liveBySea;
    private int minSalary;
    private string size;
private bool LiveBySeaSatisfied(Country country) {
    //код из метода Satisfied
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

    private bool MinSalarySatisfied(Country country) {
        if (country.AverageSalary >= minSalary) {

            return true;
        } 
        return false;
    }

    public void SetLiveBySea(bool liveBySea)
    {
        this.liveBySea = liveBySea;
    }

public void SetMinSalary(int minSalary)
{
    if (minSalary > 0)
    {
        this.minSalary = minSalary;
    } else {
        // Вместо записи System.Exception можно писать просто Exception, 
        // если в самом начале файла указать подключение пространства имен System
        // при помощи конструкции using System;
        throw new Exception("Минимальная зарплата должна быть больше 0");
    }
}
}