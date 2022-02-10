using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2_ListOfEvenNums
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> evenNums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int i = 0; i < evenNums.Count; i++)
            {
                if (evenNums[i]%2==0)
                {
                    Console.WriteLine(evenNums[i]);
                }
            }
        }
    }
}
