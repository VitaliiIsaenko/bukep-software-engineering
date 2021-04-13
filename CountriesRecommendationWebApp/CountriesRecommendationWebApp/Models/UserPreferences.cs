using System;
using CountriesRecommendationWebApp.Enums;

namespace CountriesRecommendationWebApp.Models
{
    public class UserPreferences
    {
        private bool liveBySea;
        private int minSalary;
        private CountrySize size;
        public UserPreferences(bool liveBySea, int minSalary, CountrySize size)
        {
            this.liveBySea = liveBySea;
            this.minSalary = minSalary;
            this.size = size;
        }

        public bool Satisfied(Country country)
        {
            return LiveBySeaSatisfied(country) && MinSalarySatisfied(country) && SizeSatisfied(country);
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
            }
            else
            {
                // Вместо записи System.Exception можно писать просто Exception, 
                // если в самом начале файла указать подключение пространства имен System
                // при помощи конструкции using System;
                throw new Exception("Минимальная зарплата должна быть больше 0");
            }
        }

        public void SetSize(CountrySize size)
        {
            this.size = size;
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

        private bool SizeSatisfied(Country country)
        {
            if (size == country.GetSize())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool MinSalarySatisfied(Country country)
        {
            if (country.AverageSalary >= minSalary)
            {
                return true;
            }

            return false;
        }
    }
}