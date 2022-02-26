using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_mini
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> mina = new Dictionary<string, int>();
            while (true)
            {
                string resourse = Console.ReadLine();
                if (resourse=="Stop")
                {
                    break;
                }
                int quantity = int.Parse(Console.ReadLine());
                if (mina.ContainsKey(resourse))
                {
                    mina[resourse] += quantity;
                }
                else
                {
                    mina.Add(resourse, quantity);
                }
            }
            foreach (var item in mina)
            {
                Console.WriteLine($"{item.Key}->{item.Value}");
            }
        }
    }
}
