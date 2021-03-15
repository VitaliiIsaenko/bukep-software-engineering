using System;

namespace bukep_software_engineering
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("хотите ли вы жить у моря?");
            String answer = Console.ReadLine();
            bool liveBySea;
            
            if (answer == "да")
            {
                liveBySea = true;
            }
            else
            {
                liveBySea = false;
            }
            Console.WriteLine(liveBySea);
        }
    }
}
