using System;

namespace Lecture06_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Все известные люди нашей HR компании
            Person[] people = new Person[5];
            
            people[0] = new Developer();
            Person devVictor = people[0];
            devVictor.SetName("Виктор");

            people[1] = new Designer();
            Person designerPetr = people[1];
            designerPetr.SetName("Пётр");

            Console.WriteLine(designerPetr.GetName());

            Designer designerAlex = new Designer();
            designerAlex.GetName();
        }
    }
}

// if (devVictor is Developer) {
//     Console.WriteLine(devVictor.GetName());
// }