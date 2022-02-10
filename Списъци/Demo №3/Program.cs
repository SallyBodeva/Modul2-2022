using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo__3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> num = Console.ReadLine().Split(',').ToList();
            foreach (var item in num)
            {
                Console.WriteLine(string.Join(" ",item.Split(' ').Reverse()));
            }
        }
    }
}
