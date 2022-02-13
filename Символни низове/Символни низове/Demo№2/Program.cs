using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Asen";
            string str2 = "Petar";
            int result = string.Compare(str1, str2);
            Console.WriteLine(result);
            //result=0, ако са равни
            //result<0, if str1 is before str2
            //result<0, if str2 is before str1

            string str3 = string.Concat(str1, str2);
        }
    }
}
