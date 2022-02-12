using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_2_FromStartToEnd
{
    class Program
    {
        static void Start_End(int start,int end)
        {
            for (int i = start; i <=end ; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void Main(string[] args)
        {
            Start_End(7,10);
        }
    }
}
