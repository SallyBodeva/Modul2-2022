using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_7_if_contains
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] masiv = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int element = int.Parse(Console.ReadLine());
            masiv = masiv.OrderBy(x => x).ToArray();
            for (int i = 0; i < masiv.Length; i++)
            {
                if (masiv[i]==element)
                {
                    Console.WriteLine("Yes");
                    break;
                }
                if (masiv[i] != element)
                {
                    Console.WriteLine("No");
                    break;
                }
            }
        }
    }
}
