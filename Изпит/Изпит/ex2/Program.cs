using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> season = new Dictionary<string, int>();
            while (true)
            {
                var line = Console.ReadLine().Split('-').ToList();
                if (line[0]=="END")
                {
                    break;
                }
                string name = line[0];
                int points = int.Parse(line[1]);
                if (season.ContainsKey(name))
                {
                    season[name] += points;
                }
                else
                {
                    season.Add(name, points);
                }
            }
            season = season.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in season)
            {
                Console.WriteLine($"{item.Key}=>{item.Value}");
            }
        }
    }
}
