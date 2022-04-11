using System;
using System.Collections.Generic;
using System.Text;

namespace bazar_gunu_olan.Models
{
    class Student:Person
    {
        private static int _id;
        public int Id { get; }

        string[] Lessons = new string[0];
        public Student(string name,string surname,int age)
        {
            _id++;
            Id = _id;
            Name = name;
            Surname = surname;
            Age = age;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id} - Name: {Name} - Surname: {Surname} - Age: {Age} ");
        }
    }
}
