using bazar_gunu_olan.Models;
using System;

namespace bazar_gunu_olan
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Age = -12;
            Console.WriteLine(student1.Age);
        }
    }
}
