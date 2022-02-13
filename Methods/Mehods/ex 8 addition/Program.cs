using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_8_addition
{
    class Program
    {
        static int GetMax(int a, int b)
        {
            if (a<b)
            {
                return b;
            }
            else
            {
                return a;   
            }
        }
        static char GetMax(char a, char b)
        {
            if (a < b)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
        static string GetMax(string a, string b)
        {
            if (a.Length < b.Length)
            {
                return b;
            }
            else
            {
                return a;
            }
        }
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            if (type=="int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int max = GetMax(a, b);
                Console.WriteLine(max);
            }
            if (type == "char")
            {
                char a = char.Parse(Console.ReadLine());
                char b = char.Parse(Console.ReadLine());
                char max = GetMax(a, b);
                Console.WriteLine(max);
            }
            if (type == "string")
            {
                string a =Console.ReadLine();
                string b = Console.ReadLine();

                string max = GetMax(a, b);
                Console.WriteLine(max);
            }
        }
    }
}
