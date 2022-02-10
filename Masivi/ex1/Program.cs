using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int min = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (min > nums[i])
                {
                    min = nums[i];
                }
            }
            Console.WriteLine($"Min = {min}");
            Console.WriteLine($"Max = {nums.Max()}");
            Console.WriteLine($"Max = {nums.Sum()}");
            Console.WriteLine($"Max = {nums.Average()}");
        }
    }
}
