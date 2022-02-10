using System;

namespace ex_3_speed
{
    class Program
    {
        static void Main(string[] args)
        {
            float m = float.Parse(Console.ReadLine());
            float hours = float.Parse(Console.ReadLine());
            float minutes = float.Parse(Console.ReadLine());
            float sec = float.Parse(Console.ReadLine());

            float time = hours * 3600 + minutes * 60 + sec;
            float m_s = m / time;
            Console.WriteLine(Math.Round(m_s,7));

            float km = m / 1000f;
            float time_h = time / 3600;
            Console.WriteLine(Math.Round(km/time_h,6));

            float milq = m / 1609f;
            float time_milq = time / 3600;
            Console.WriteLine(Math.Round(milq/ time_milq, 6));

        }
    }
}
