using System;

namespace ЛР1
{
    class ЛР1_Krekshin
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Хотите ли вы жить у моря?");

            string answer = Console.ReadLine();

            bool LiveBySea;

            if (answer == "да")
            {
                LiveBySea = true;
            }
            else
            {
                LiveBySea = false;
            }

            Console.WriteLine(LiveBySea);
        }
    }
}
