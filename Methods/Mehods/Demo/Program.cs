using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        private static void PrintHeader()
        {
            Console.WriteLine("+++++++++++++++++++++");
        }
        private static void Footer ()
            {
             Console.WriteLine("*******************");
            }
        static void PrintAll()
        {
            PrintHeader();
            Footer();
        }
        static void Main(string[] args)
        {
            PrintAll();
        }
    }
}
