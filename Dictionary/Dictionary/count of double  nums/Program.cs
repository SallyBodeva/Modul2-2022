using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count_of_double__nums
{
    class Program
    {
        static void Main(string[] args)
        {

            Dictionary<double, int> num = new Dictionary<double, int>();
            var line = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
            foreach (var item in line)
            {
                if (num.ContainsKey(item))
                {
                    num[item]++;
                }
                else
                {
                    num[item] = 1;
                }
            }
            num = num.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in num)
            {
                Console.WriteLine($"{item.Key}=>{item.Value}");
            }
        }
    }
}
