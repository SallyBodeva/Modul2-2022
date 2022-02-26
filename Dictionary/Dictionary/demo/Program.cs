using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>();
            Dictionary<string, int> person = new Dictionary<string, int>();
            num.Add(11);
            num.Add(28);
            
            Console.WriteLine(string.Join(" ",num));
            person.Add("Salihe", 16);
            person.Add("Ati", 17);
            person["Asen"] = 22;
            Console.WriteLine(string.Join(" ",person));
            //Печат само на ключ
            foreach (var item in person)
            {
                Console.WriteLine($"{item.Key}");
            }
            Console.WriteLine();
            int s = 0;
            foreach (var item in person)
            {
                Console.WriteLine($"{item.Key}=>{item.Value}");
                s += item.Value;
            }
            Console.WriteLine(s);
        }
    }
}
