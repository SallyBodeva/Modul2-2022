using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_5_edit1
{
    class Program
    {
        static void Main(string[] args)
        {
            var masiv = Console.ReadLine().Split(' ').ToArray();
            int n = int.Parse(Console.ReadLine());
            while (n>0)
            {
                var cmn = Console.ReadLine().Split(' ').ToArray();
                switch (cmn[0])
                {
                    case "Reverse":
                        masiv = masiv.Reverse().ToArray();
                        break;
                    case "Distinct":
                        masiv = masiv.Distinct().ToArray();
                        break;
                    case "Replace":
                        masiv[int.Parse(cmn[1])] = cmn[2];
                        break;
                    default:
                        break;
                }
                n--;
                Console.WriteLine(string.Join(" ", masiv));
            }
            
        }
    }
}
