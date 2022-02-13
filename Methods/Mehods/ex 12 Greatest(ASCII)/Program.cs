using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_12_Greatest_ASCII_
{
    class Program
    {
      static void Print (string word)
        {
            int max = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (max<word[i])
                {
                    max = word[i];
                }
            }
            Console.WriteLine($"{(char)(max)}=>{max}");
        }
        static void Main(string[] args)
        {
            Print(Console.ReadLine());
        }
    }
}
