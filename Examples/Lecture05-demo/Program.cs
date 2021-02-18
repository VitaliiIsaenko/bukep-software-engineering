using System;

namespace Lecture05_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // // победитель
            // bool isWinner = true;
            // // isWinner2 = true
            // bool isWinner2 = isWinner;

            // isWinner2 = false;

            // // true
            // Console.WriteLine(isWinner);
            // // false
            // Console.WriteLine(isWinner2);

            // // double/int/bool/char

            // Student student1 = new Student(); // #bn987
            // student1.name = "Victor"; // (#bn987).name = "Victor"

            // Student student2 = new Student(); // #ab123
            // student2.name = "Petr"; // (#ab123).name = "Petr"

            // // Victor
            // Console.WriteLine(student1.name);
            // // Petr
            // Console.WriteLine(student2.name);


            // Student student1 = new Student(); // #bn987
            // student1.name = "Victor"; // (#bn987).name = "Victor"
            // student1.name = "Petr"; // (#bn987).name = "Petr"

            // Console.WriteLine(student1.name); // Petr

            // Student student1 = new Student(); // #bn987
            // student1.name = "Victor"; // (#bn987).name = "Victor"
            // Student student2 = student1; // Student student2 = #bn987
            // student2.name = "Petr"; // (#bn987).name = "Petr"

            // Console.WriteLine(student1.name); // Petr
            // Console.WriteLine(student2.name); // Petr
            
            
            student1.SetName("Victor");
            Console.WriteLine("Дорогой " + student1.GetName() + " оплатите обучение");

            Console.WriteLine("Уважаемый мистер " + student1.name + " приходите на лабораторные занятия");

            if (student1.Age < 18) {
                Console.WriteLine("Уважаемый мистер " + student1.name + " У вас нет доступа");
            } else {
                Console.WriteLine("Уважаемый мистер " + student1.name + " У вас есть доступ");
            }
         }
    }
}
