using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_Censor
{
    class Program
    {
        static void Main(string[] args)
        {
            string censor = Console.ReadLine();
            string words = Console.ReadLine();
            foreach (var item in words)
            {
                if (words.Contains(censor))
                {
                    words = words.Replace(censor, new string('*', censor.Length));
                }
            }
            Console.WriteLine(words);
        }
    }
}
