using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine($"Max{num.Max()}");
            Console.WriteLine($"Max{num.Min()}");
            Console.WriteLine($"Max{num.Sum()}");
            Console.WriteLine($"Max{num.Average():f2}");

            num = num.OrderByDescending(x => x).ToList();
        }
    }
}
