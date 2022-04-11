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
        public Student()
        {
            _id++;
            Id = _id;
        }
    }
}
