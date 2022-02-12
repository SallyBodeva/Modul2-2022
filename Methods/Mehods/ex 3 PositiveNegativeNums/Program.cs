using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_3_PositiveNegativeNums
{
    class Program
    {
        static void Nums_Type(int a)
        {
            if (a >0)
            {
                Console.WriteLine($"{a} is Positive");
            }
            else if (a<0)
            {
                Console.WriteLine($"{a} is Negative");
            }
            else 
            {
                Console.WriteLine($"{a} is Zero ");
            }
        }
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Nums_Type(num);

        }
    }
}
