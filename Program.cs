using System;

namespace bukep_software_engineering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Хотите ли вы жить у моря?");
            string answer = Console.ReadLine();
            bool LiveBySea;
            if (answer == "Да")
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
