using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_6_areaRectangle
{
    class Program
    {
        static double Area(double a ,double h)
        {
            return a * h / 2;
        }
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double S = Area(a, h);
            Console.WriteLine(S);

        }
    }
}
