using System;

namespace ex_Special_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           

            for (int i = 0; i < n; i++)
            {
                int sumOfDigiys = 0;
               int digits  = i;
                while (digits>0)
                {
                    sumOfDigiys += digits % 10;
                    digits /= 10;
                }
                if (sumOfDigiys==5 || sumOfDigiys == 7||sumOfDigiys == 11)
                {
                    Console.WriteLine($"{i} -> TRue");
                }
                else
                {
                    Console.WriteLine($"{i} -> Falsr");
                
                 }
            }
        }
    }
}
