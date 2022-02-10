using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_7_SqurNums
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            nums = nums.OrderByDescending(x => x).ToList();

            foreach (var item in nums)
            {
                if (Math.Sqrt(item)==(int)Math.Sqrt(item))
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
