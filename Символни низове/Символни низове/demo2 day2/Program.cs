using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo2_day2
{
    class Program
    {
        static void Main(string[] args)
        {
            string coctail = "Vodka + Martini+ Cherry";
            string newCoc = coctail.Replace("+", "and");
          //  Console.WriteLine(newCoc);

            string number = "123456789";
            string newNum= number.Remove(3, 3);
            Console.WriteLine(newNum);


        }
    }
}
