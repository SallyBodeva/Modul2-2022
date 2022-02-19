using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4_Multiply
{
    class Program
    {
        static int sumMulptiply(string word1, string word2)
        {
           int  sum = 0;
            int min = Math.Min(word1.Length, word2.Length);
            //Първата дума е по-кратка
            if (word1.Length<=word2.Length)
            {
                for (int i = 0; i < min; i++)
                {
                    sum += (int)word1[i] * (int)word2[i];
                }
                for (int i = min; i < word2.Length; i++)
                {
                    sum += (int)word2[i];
                }
            }
            //Втората дума е по-кратка
            if (word2.Length <= word1.Length)
            {
                for (int i = 0; i < min; i++)
                {
                    sum += (int)word1[i] * word2[i];
                }
                for (int i = min; i < word1.Length; i++)
                {
                    sum += (int)word1[i];
                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ').ToArray();
            string word1 = line[0];
            string word2 = line[1];
           int a = sumMulptiply(word1, word2);
            Console.WriteLine(a);
        }
    }
}
