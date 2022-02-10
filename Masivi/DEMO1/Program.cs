using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEMO1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "mon", "tues", "wed", "thur", "fri", "sat", "sun" };
            int day = int.Parse(Console.ReadLine());


            for (int i = 0; i < days.Length; i++)
            {
                if (day==(i+1))
                {
                    Console.WriteLine(days[day]);
                }
               
            }
        }
    }
}
