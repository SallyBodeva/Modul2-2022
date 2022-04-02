using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_2020_exam
{
    class Program
    {
        static void Main(string[] args)
        {
            var specialWord = Console.ReadLine().Split(' ').ToList();
            var otherlWord = Console.ReadLine().Split(' ').ToList();
            int br = int.Parse(Console.ReadLine());
            for (int i = 0; i < br; i++)
            {
                string word = Console.ReadLine();
                bool isUpper = char.IsUpper(word[0]);
                bool isGreater7 = (word.Length > 7);
                bool isContain_i = word.Contains('i');
                if (isUpper&&isContain_i&&isGreater7)
                {
                    specialWord.Add(word);
                }
                else
                {
                    otherlWord.Add(word);
                }
            }
            Console.WriteLine($"Special word:{string.Join(",",specialWord)}");
            Console.WriteLine($"Other word:{string.Join(",", otherlWord)}");

        }
    }
}
