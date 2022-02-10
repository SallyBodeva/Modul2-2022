using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_8_sumOfReverseNums
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').ToList();
            for (int i = 0; i < list.Count; i++)
            {
                list[i] = string.Join(" ", list[i].Reverse());
            }
            int sum = list.Select(int.Parse).Sum();
            Console.WriteLine(string.Join(" ",list));
            Console.WriteLine(sum);

        }
    }
}
