using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string template = Console.ReadLine();
            int counter = 0;
            int FirstTemplateIndex = input.IndexOf(template);
            while (FirstTemplateIndex!=-1)
            {
                counter++;
                int index = input.IndexOf(template, FirstTemplateIndex + 1);
            }
            Console.WriteLine(counter);
        }
    }
}
