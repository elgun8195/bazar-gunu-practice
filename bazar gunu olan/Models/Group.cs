using System;
using System.Collections.Generic;
using System.Text;

namespace bazar_gunu_olan.Models
{
    class Group
    {
        private Student[] students;
        int GroupNo;

        public Group()
        {
            students = new Student[0];
        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }
    }
}
