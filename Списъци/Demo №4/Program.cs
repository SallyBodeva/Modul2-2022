using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo__4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>() { 11, -2, 3, 11, 4, -5, 11, -6, 11 };
            Console.WriteLine(string.Join(" ",nums));
            nums.Remove(11);
            Console.WriteLine(string.Join(" ", nums));
            while (nums.Contains(11))
            {
                nums.Remove(11);
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
