using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_1_CashReceipt
{
    class Program
    {
        static void PrintHeader()
        {
            Console.WriteLine("Cash Receipt");
            Console.WriteLine("----------------------");
        }
        static void Middle ()
        {
            Console.WriteLine("Charged to_____________________");
            Console.WriteLine("Received by_____________________");
        }
        static void Footer()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("SoftUni@");  
        }
        static void Main(string[] args)
        {
            PrintHeader();
            Middle();
            Footer();
        }
    }
}
