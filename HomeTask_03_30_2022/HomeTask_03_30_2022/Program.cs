using System;

namespace HomeTask_03_30_2022.Models
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var a = new Student("ad1","soyad1",12,90);
            var b = new Student("ad2", "soyad2", 42, 34);
            var c = new Student("ad3", "soyad3", 19, 60);
            a.showInfo();
            b.showInfo();
            c.showInfo();
            
            var z = new Group();
            var y = new Group();
            z.showInfo();
            y.showInfo();
            z.AddStudents(a);
            z.AddStudents(b);
            z.AddStudents(c);
            z.GetAllStudents();
            Console.WriteLine("___________");
            z.Sort();
            z.GetAllStudents();

          
        }
    }
}
