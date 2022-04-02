using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace изпитна_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> visitors = Console.ReadLine().Split(',').ToList();
            while (true)
            {
                string command = Console.ReadLine();
                if (command=="END")
                {
                    break;                  
                }
                if (command=="Add vistor")
                {
                    string name = Console.ReadLine();
                    visitors.Add(name);
                }
                if (command == "Add vistor on position")
                {
                    string name = Console.ReadLine();
                    int position = int.Parse(Console.ReadLine());
                    visitors.Insert(position, name);
                }
                if (command == "Remove vistor on position")
                {
                   
                    int position = int.Parse(Console.ReadLine());
                    visitors.RemoveAt(position);
                }
                if (command == "Remove last vistor")
                {
                    visitors.RemoveAt(visitors.Count - 1);

                }
                if (command == "Remove first visitor")
                {
                    visitors.RemoveAt(0);
                }
            }
            Console.WriteLine(string.Join(", ", visitors));
        }
    }
}
