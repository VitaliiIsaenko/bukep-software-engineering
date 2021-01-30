using System;
using System.Linq;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {

            // Консоль.НаприсатьСтроку("Укажите оценки");
            Console.WriteLine("Укажите оценки");
            // Переменная оценки = Консоль.СчитатьСтроку()
            var grades = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            

            // С добрыми программистами:
            // Переменная сумма = оценки.Среднее();
            // var summ = grades.Average();

            // Без добрых программистов
            // Переменная количество = оценки.Длина;
            var amount = grades.Length;
            // Переменная сумма = 0;
            var sum = 0;
            // Для каждой(переменной оценка в оценках) {
            foreach(var grade in grades) {
                //сумма = сумма + оценка;
                sum = sum + grade;
            }
            //нецелое_число среднее = сумма / количество; 
            double average = sum / amount;

            
            // Консоль.НаписатьСтроку($"Средняя оценка: {сумма}");
            Console.WriteLine($"Средняя оценка: {sum}");

        }
    }
}
