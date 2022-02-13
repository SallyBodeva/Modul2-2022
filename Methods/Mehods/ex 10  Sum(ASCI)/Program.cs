using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_10__Sum_ASCI_
{
    class Program
    {
       static int Sum(string type )
        {
            int sum = 0;
            for (int i = 0; i < type.Length; i++)
            {
                sum += type[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
           int sum = Sum(type);
            Console.WriteLine(sum);
           
        }
    }
}
