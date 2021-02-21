using System;

namespace Lecture05
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 1;
            // Присвоили переменной num2 значение переменной num1
            int num2 = num1; // num2 = 1
            //Изменили значение переменной num2
            num2 = 2;

            Console.WriteLine(num1); // 1
            Console.WriteLine(num2); // 2

            Student student1 = new Student(); // ссылку #ds3re32d
            // Изменили значение age объекту по ссылке #ds3re32d
            student1.age = 18;
            // Присвоили переменной student2 ссылку #ds3re32d
            Student student2 = student1;
            // Изменили значение age объекту по ссылке #ds3re32d
            student2.age = 20;

            Console.WriteLine(student1.age); // 20
            Console.WriteLine(student2.age); // 20

            Student student1 = new Student();
            student1.age = 17;
            Increment(student1);
            Console.WriteLine(student1.age); // 18

            int num = null;

            int num1 = 1;
            Increment(num1);
            Console.WriteLine(num1); // 1

            Student student;
            Increment(student);
        }

        // Student student = student1;
        public static void Increment(Student student)
        {
            if (student != null)
            {
                student.age++;
            }
        }

        // int num = num1
        public static void Increment(int num)
        {
            num++;
        }
    }
}
