using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_4_DrawRectangle
{
    class Program
    {
        static void PrintHeaderAndFooter(int n)
        {
            Console.WriteLine(new string('-', 2 * n));
        }
        static void Middle(int n )
        {
            for (int i = 0; i < n - 2; i++)
            {
                Console.Write('-');
                for (int j = 0; j < n - 1; j++)
                {
                    Console.Write("\\/");
                }
                Console.Write('-');
                Console.WriteLine();
            }

        }
        static void PrintAll(int n)
        {
            PrintHeaderAndFooter(n);
            Middle(n);
            PrintHeaderAndFooter(n);
        }
        static void Main(string[] args)
        {
            PrintAll(int.Parse(Console.ReadLine()));     
            
        }
    }
}
