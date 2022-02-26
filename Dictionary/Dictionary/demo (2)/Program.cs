using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вход на елементи от ред по ред
            Dictionary<string, int> person = new Dictionary<string, int>();
            Console.Write("Broi:");
            int br = int.Parse(Console.ReadLine());
            for (int i = 0; i < br; i++)
            { 
                Console.Write("Stoka: ");
                string name = Console.ReadLine();
                Console.Write("Kolichestvo: ");
                int age = int.Parse(Console.ReadLine());
               
                if (person.ContainsKey(name))
                {
                    person[name] += age;
                }
                else
                {
                    person.Add(name, age);
                }
            }
            foreach (var item in person)
            {
                Console.WriteLine($"{item.Key}=>{item.Value}");
            }
        }
    }
}
