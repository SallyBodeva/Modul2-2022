using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_5_F_to_C
{
    class Program
    {
        static double Temperature(double n)
        {
            double celsius = (n - 32) * 5 / 9;
            return celsius;

        }
        static void Main(string[] args)
        {
            double t = Temperature(double.Parse(Console.ReadLine()));
            Console.WriteLine($"{t:f2}");

        }
    }
}
