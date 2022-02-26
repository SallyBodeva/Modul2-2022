using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_phone_numbers
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
                    string phoneNum = line[2];
                    
                    if (phonebook.ContainsKey(name))
                    {
                        phonebook[name] = phoneNum;
                    }
                    else
                    {
                        phonebook.Add(name, phoneNum);
                    }
                }
                if (line[0]=="S")
                {
                    string namePrint = line[1];
                    if (phonebook.ContainsKey(namePrint))
                    {
                        Console.WriteLine($"{namePrint}=>{phonebook[namePrint]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact:{namePrint} does not exist");
                    }
                }
                if (line[0]=="Print")
                {
                    foreach (var item in phonebook)
                    {
                        Console.WriteLine($"{item.Key}->{item.Value}");
                    }
                }
            }
        }
    }
}
