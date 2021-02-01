using System;

namespace Lecture03
{
    class Program
    {
        static void Main(string[] args)
        {
        // var grades = new int[] { 5, 4, 5, 4 };

        // var amount = grades.Length;
        // var sum = 0;
        // for (int i = 0; i < grades.Length; i++)
        // {
        //     sum = sum + grades[i];
        // }
        // double average = sum / amount;
        var grades = new int[] { 5, 4, 5, 4 };
        var average = Average(grades);
        Console.WriteLine($"Среднее арифметическое оценок студента: {average}");


        // var years = new int[] { 19, 21, 16, 17 };

        // var amount = years.Length;
        // var sum = 0;
        // for (int i = 0; i < years.Length; i++)
        // {
        //     sum = sum + years[i];
        // }
        // double average = sum / amount;

        // Console.WriteLine($"Среднее арифметическое возраста студентов: {average}");

        var years = new int[] { 19, 21, 16, 17 };
        var average = Average(years);
        Console.WriteLine($"Среднее арифметическое возраста студентов: {average}");
        }

        public static double Average(int[] numbers) {
            int amount = numbers.Length;
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
            double average = sum / amount;
            return average;
        }
    }
}
