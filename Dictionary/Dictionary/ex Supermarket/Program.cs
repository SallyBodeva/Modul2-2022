using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> market1 = new Dictionary<string, List<double>>();
            double s = 0;
            while (true)
            {
                var line = Console.ReadLine().Split(' ').ToList();
                string stoka = line[0];
                if (stoka=="Stocked")
                {
                    break;
                }
                double price = double.Parse(line[1]);
                double quantity = double.Parse(line[2]);

                if (market1.ContainsKey(stoka))
                {
                    if (market1[stoka][0]!=price)
                    {
                        market1[stoka][0] = price;
                    }
                    market1[stoka][1] += quantity;
                }
                else
                {
                    var CenaKOl = new List<double>();
                    CenaKOl.Add(price);
                    CenaKOl.Add(quantity);
                    market1.Add(stoka, CenaKOl);
                }
               
                
            }

            foreach (var item in market1)
            {
                Console.WriteLine($"{item.Key}:${item.Value[0]:f2}*{item.Value[1]}= ${item.Value[0] * item.Value[1]:f2}");
                s = item.Value[0] * item.Value[1];
            }

            Console.WriteLine("*************************************");
            Console.WriteLine($"Grand Total:{s:f2}");
        }
    }
}
