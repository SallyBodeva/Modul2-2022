using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo_day_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = "Aligator";
            int index = word.IndexOf("t");
            Console.WriteLine(index);

            int indexA = word.IndexOf("a", 3);
            Console.WriteLine(indexA);
            string newWord = word.Substring(3, 3);
            Console.WriteLine(newWord);
            string replaceword = word.Replace('g','G') ;
            Console.WriteLine(replaceword);
        }
    }
}
