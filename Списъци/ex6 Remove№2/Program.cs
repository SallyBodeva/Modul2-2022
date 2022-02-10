using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex6_Remove_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int lastItem = nums[nums.Count - 1];
            while (nums.Contains(lastItem))
            {
                nums.Remove(lastItem);
            }
            Console.WriteLine(string.Join(" ",nums));
        }
    }
}
