using System;

namespace ex2_rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double area = a * b;
            double p = 2*a+2*b;
            double d = Math.Sqrt(a * a + b * b);

            Console.WriteLine(area);
            Console.WriteLine(p);
            Console.WriteLine(d);
        }
    }
}
