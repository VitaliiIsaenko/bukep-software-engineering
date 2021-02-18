using System;

namespace Lecture06
{
    class Program
    {
        static void Main(string[] args)
        {
            Course oldCourse = new Course(new University("БУКЭП", "Садовая 118а"), "Технология разработки ПО", "ауд. 09");
            Console.WriteLine(oldCourse.GetLocation()); // Садовая 118а ауд. 09

            RemoteCourse newCourse = new RemoteCourse(new University("БУКЭП", "Садовая 118а"), "Технология разработки ПО", "Zoom");
            Console.WriteLine(newCourse.GetLocation()); // Zoom
        }
    }
}
