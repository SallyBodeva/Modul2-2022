using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_9_ReversedName
{
    class Program
    {
        static void Reverse(string  word )
        {
            for (int i = word.Length-1; i >= 0; i--)
            {
                Console.Write(word[i]);
            }
            
        }
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Reverse(word);
        }
    }
}
