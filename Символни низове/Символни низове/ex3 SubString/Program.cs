using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_SubString
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "@c/fvnf/Rila/jpg";
            string name = filename.Substring(8,4);
            Console.WriteLine(name);
        }
    }
}
