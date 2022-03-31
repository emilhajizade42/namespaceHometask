using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace HomeTask_03_30_2022.Models
{
    internal class Student
    {
        private static int id=0;
        private string name;
        private string surname;
        private int age;
        public int point;

        public int ID
        {
            get;
            private set;
        }

        public void showInfo()
        {
            Console.WriteLine($"{ID} , {name} , {surname} , {age} , {point}");
        }
        public Student(string Name, string Surname , int Age , int Point)
        {
            name = Name;
            surname = Surname;
            age = Age;
            point = Point;
            id++;
            ID = id; 

        }
    }
}
