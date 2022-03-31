using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask_03_30_2022.Models
{
    internal class Group
    {
        private static int name=200;
        public string Name { get; set; }
        public Student[] Students = { };


        public  void showInfo()
        {
            Console.WriteLine($"{Name}");
        }
        public void AddStudents(Student obj)
        {
           Array.Resize(ref Students,Students.Length+1);
            Students[Students.Length-1] = obj;
        }
        public void GetAllStudents()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                Students[i].showInfo();
            }
        }
        public void Sort()
        {
            Array.Sort(Students,
                 delegate (Student x, Student y) { return x.point.CompareTo(y.point); });
        }
        public Group()
        {
            name++;
            Name = "BP"+name;

        }
    }
}
