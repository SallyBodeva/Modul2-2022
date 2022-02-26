using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demp
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> person = new Dictionary<string, int>();
            int br = int.Parse(Console.ReadLine());
            for (int i = 0; i < br; i++)
            {
                var line = Console.ReadLine().Split(' ').ToList();
                string name = line[0];
                int age = int.Parse(line[1]);
                if (person.ContainsKey(name))
                {
                    person[name] = age;
                }
                else
                {
                    person.Add(name, age);
                }
            }
            //Сортировка на речник
            person = person.OrderBy(x => x.Value).ThenBy(x=>x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in person)
            {
                Console.WriteLine($"{item.Key}=>{item.Value}");
            }
            //Изтримане на ключ
            Console.WriteLine();
            Console.WriteLine("Ime za iztrivane");
            string nameDel = Console.ReadLine();
            person.Remove(nameDel);

            foreach (var item in person)
            {
                Console.WriteLine($"{item.Key}=>{item.Value}");
            }
        }
    }
}
