using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            //Преобразуване на стринг до char.Array
            char[] string1 = word.ToCharArray();
            Console.WriteLine(string.Join(",",string1));
            //Преобразуване на char.Array  =>string
            string str2 = new string(string1);
        }
    }
}
