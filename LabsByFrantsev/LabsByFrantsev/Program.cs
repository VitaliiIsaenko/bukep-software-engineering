using System;

namespace LabsByFrantsev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Хотите ли вы жить у моря?");
            var answer = Console.ReadLine();
            bool liveBySea;

            if (answer == "да")
            {
                liveBySea = true;
            }
            else if (answer == "нет")
            {
                liveBySea = false;
            }
            else
            {
                Console.WriteLine("Введен неудовлетворяющий ответ");
            }

            Console.ReadKey();
        }
    }
}
