using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_8_BiggerNum
{
    class Program
    {
        static int Bigger_Num(int a , int b)
        {
            if (a>b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static char letter(char a, char b)
        {
            if (a > b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
        static string word(string first, string second)
        {
            if (first.CompareTo(second)>=0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        static void Main(string[] args)
        {

            string type = Console.ReadLine();
            if (type=="int")
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int Get_Max = Bigger_Num(a, b);

            }
            else if (type == "char")
            {
                char a1 = char.Parse(Console.ReadLine());
                char b1 = char.Parse(Console.ReadLine());
                char max = letter(a1, b1);
                Console.WriteLine(max);

            }
            else if (type=="string")
            {
                string first = Console.ReadLine();
                string second = Console.ReadLine();
                string max = word(first, second);
                Console.WriteLine(max);
            }

        }
    }
}
