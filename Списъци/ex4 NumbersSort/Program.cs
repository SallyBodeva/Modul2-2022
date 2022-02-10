using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_NumbersSort
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            list = list.OrderBy(x => x).ToList();
            Console.WriteLine(string.Join("<=",list));
        }
    }
}
