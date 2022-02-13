using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_Beers
{
    class Program
    {
        static void Main(string[] args)
        {
            string beer = "shumensko zagorka,tuborg:Corona";
            string[] bira = beer.Split(' ', ',', ':');
            Console.WriteLine(string.Join(" ",bira));
        }
    }
}
