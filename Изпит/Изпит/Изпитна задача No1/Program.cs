using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Изпитна_задача_No1
{
    class Program
    {
        static void Main(string[] args)
        {
            int broi = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < broi; i++)
            {
                string facilities = Console.ReadLine();
                if (facilities=="treadmill")
                {
                    sum += 5899;
                }
                if (facilities == "cross trainer")
                {
                    sum += 1699;
                }
                if (facilities == "exercise bike")
                {
                    sum += 1789;
                }
                if (facilities == "dumbells")
                {
                    sum += 579;
                }
            }
            Console.WriteLine($"{sum:f2}$");
        }
    }
}
