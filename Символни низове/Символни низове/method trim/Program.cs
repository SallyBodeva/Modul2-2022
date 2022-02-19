using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_trim
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = "   Javascript";
            words = words.Trim();
            Console.WriteLine(words);
            string s = " , Asen  Ivanon:uchitel na 33 godini";
            s = s.Trim('t', ' ', '!');
            Console.WriteLine(s);
        }
    }
}
