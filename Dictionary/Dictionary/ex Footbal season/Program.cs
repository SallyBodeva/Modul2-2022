using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex_Footbal_season
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> season = new Dictionary<string, int>();
            while (true)
            {
                var line = Console.ReadLine().Split('-').ToList();
                string name = line[0];
                if (name=="end")
                {
                    break;
                }
                int goal = int.Parse(line[1]);
                if (season.ContainsKey(name))
                {
                    season[name] += goal;
                }
                else
                {
                    season.Add(name, goal);
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
