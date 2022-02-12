using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo__3
{
    class Program
    {
        static void AddOne (int a )
        {
            a++;
            Console.WriteLine(a);
        }
        static int PlusOne(int a )
        {
            a++;
            return a;
        }
        static void Main(string[] args)
        {
            // int number = int.Parse(Console.ReadLine());
            //AddOne(number);
            int plus1 = PlusOne(int.Parse(Console.ReadLine()));
            Console.WriteLine(plus1);
        }
    }
}
