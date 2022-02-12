using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo__2
{
    class Program
    {
        static void Student (string name, int age)
        {
            Console.WriteLine($"{name} is {age} years old! ");
            Console.WriteLine();
        }
        static void Main(string[] args)
        {

            Console.WriteLine("Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Age: ");
            int age = int.Parse(Console.ReadLine());
            Student(name,age);
        }
    }
}
