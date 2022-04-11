using System;
using System.Collections.Generic;
using System.Text;

namespace bazar_gunu_olan.Models
{
    class Teacher:Person
    {
        private int _exp;
        private static int _id;
        public int Id { get; set; }
        public int Experience
        {
            get { return _exp; }
            set
            {
                if (value >= 1 && value <= 80)
                {
                    _exp = value;
                }
            }
        }

        public Teacher(string name,string surname,int age,int experience)
        {
            _id++;
            Id = _id;
            Name = name;
            Surname = surname;
            Age = age;
            Experience = experience;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Id: {Id} - Name: {Name} - Surname: {Surname} - Age: {Age} - Experience: {Experience}");
        }
    }
}
