using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            while (true)
            {
                var line = Console.ReadLine().Split(' ').ToList();
                if (line[0]=="END")
                {
                    break;
                }
                if (line[0]=="A")
                {
                    string name = line[1];
                    string phone = line[2];
                    if (phonebook.ContainsKey(name))
                    {
                        phonebook[name] = phone;
                    }
                    else
                    {
                        phonebook.Add(name, phone);
                    }
                }
                if (line[0]=="S")
                {
                    string name = line[1];
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name}->{phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist!");
                    }
                }
            }
          
        }
    }
}
