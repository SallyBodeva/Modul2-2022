using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_broi_dumi
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> words = new Dictionary<string, int>();
            var line = Console.ReadLine().ToLower().Split(' ').ToList();
            foreach (var item in line)
            {
                if (words.ContainsKey(item))
                {
                    words[item]++;
                }
                else
                {
                    words[item] = 1;
                }
            }
            words = words.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in words)
            {
                if (item.Value%2!=0)
                {
                    Console.WriteLine($"{item.Key}, ");
                }
            }
        }

    }
}
