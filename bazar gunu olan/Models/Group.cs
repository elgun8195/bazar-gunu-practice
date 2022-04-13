﻿using System;
using System.Collections.Generic;
using System.Text;

namespace bazar_gunu_olan.Models
{
    class Group
    {
        public Student[] students = new Student[0];
        int GroupNo;

        
        public void AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
        }
    }
}
