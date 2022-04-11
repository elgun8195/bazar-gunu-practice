using bazar_gunu_olan.Models;
using System;

namespace bazar_gunu_olan
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int experience;

            do
            {
                Console.WriteLine("Studentin Yasini Girin: ");
                age = Convert.ToInt32(Console.ReadLine());
            } while (age==0 || age<0);

            Student student1 = new Student("Elgun","Qocayev",age);

            do
            {
                Console.WriteLine("Teacherin Yasini Girin: ");
                age = Convert.ToInt32(Console.ReadLine());
            } while (age == 0 || age < 0);


            do
            {
                Console.WriteLine("Experience'ni Daxil Edin: ");
                experience = Convert.ToInt32(Console.ReadLine());   
            } while (experience<1 || experience>80);


            Teacher teacher = new Teacher("Ulvi", "Macid",age,experience);   
            teacher.ShowInfo();
            student1.ShowInfo();


            Group group1 = new Group();
            group1.AddStudent(student1);
            
            
        }
    }
}
