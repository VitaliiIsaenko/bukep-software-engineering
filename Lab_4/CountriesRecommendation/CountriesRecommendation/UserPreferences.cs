public class UserPreferences {

    private bool liveBySea;
    private int minSalary;
    private string size;

    public bool Satisfied(Country country) {
        if (LiveBySeaSatisfied(country) & MinSalarySatisfied(country)) {
            return true;
        } else {
            return false;
        }
    }

    private bool LiveBySeaSatisfied(Country country) {
        if (liveBySea) {
            if (country.HasSea) {
                return true;
            } else {
                return false;
            }
        } else {
            return true;
        }
    }

    private bool MinSalarySatisfied(Country country) {
        if (country.AverageSalary < minSalary) {
            return false;
        } else {
            return true;
        }
    }

    public void SetLiveBySea(bool liveBySea) {
        this.liveBySea = liveBySea;
    }

    public void SetMinSalary(int minSalary) {
        if (minSalary > 0) {
            this.minSalary = minSalary;
        } else {
            throw new System.Exception("Минимальная зарплата должна быть больше 0");
        }
    }
}