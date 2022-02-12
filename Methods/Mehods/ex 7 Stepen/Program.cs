using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_7_Stepen
{
    class Program
    {
        static double stepen(double osn,double ste)
        {
            double result = 1;
            for (int i = 0; i < ste; i++)
            {
                result *= osn;
            }
            return result;
        }
        static void Main(string[] args)
        {
            double osn = double.Parse(Console.ReadLine());
            double ste = double.Parse(Console.ReadLine());

            double R = stepen(osn, ste);
            Console.WriteLine(R);
        }
    }
}
