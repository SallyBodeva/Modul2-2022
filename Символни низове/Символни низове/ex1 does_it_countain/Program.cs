using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1_does_it_countain
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "hamurapi@.abv.bg";
            int FirstIndex = str.IndexOf("a");
            int SecondIndex = str.IndexOf("a",4);
            Console.WriteLine(SecondIndex);
            int ThirdIndex = str.IndexOf("rap");
            Console.WriteLine(ThirdIndex);
        }
    }
}
