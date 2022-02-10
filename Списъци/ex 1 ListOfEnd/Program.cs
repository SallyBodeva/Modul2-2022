using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1_ListOfEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int max = num.Max();
            int min = num.Min();
            Console.WriteLine(string.Join(" ",num.Where(x=>x==min)));
            Console.WriteLine(string.Join(" ", num.Where(x => x == max)));
        }
    }
}
