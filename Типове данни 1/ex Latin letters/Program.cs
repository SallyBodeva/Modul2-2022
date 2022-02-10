using System;

namespace ex_Latin_letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int h = 0; h < n; h++)
                {
                    for (int p = 0; p < n; p++)
                    {
                        Console.WriteLine($"{(char)('a' + i)}{(char)('a'+h)}{(char)('a' + p)}");
                    }
                }
            }
        }
    
    }
}
