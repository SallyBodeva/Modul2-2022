using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex11_Sum_Even_Odd_nums
{
    class Program
    {
        static int sum(int n)
        {
            return sum_even(n) * sum_odd(n);
        }
      static int sum_even(int n)
        {
            n = Math.Abs(n);
            int sum = 0;
            while (n >= 0)
            {
                if ((n % 10) % 2 == 0)
                {
                    sum += n % 10;
                    sum += n / 10;

                }
            }
            return sum;
        }
        static int sum_odd(int n)
        {
            n = Math.Abs(n);
            int sum = 0;
            while (n >= 0)
            {
                if ((n % 10) % 2 == 1)
                {
                    sum += n % 10;
                    sum += n / 10;

                }
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sum1 = sum(n);
            Console.WriteLine(sum1);

        }
    }
}
