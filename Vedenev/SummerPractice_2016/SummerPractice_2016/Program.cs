using System;
using OpaqueFunctions;

namespace SummerPractice_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            double mx = 0, mid = 0, x, t;
            Random random = new Random();
            for (int i = 0; i < 10; ++i)
            {
                x = random.NextDouble() * 200 + 100;
                t = CL00_67_1_ch_sh.Body(x);
                Console.WriteLine(x.ToString() + " " + t.ToString());
                mid += t;
                if (t > mx)
                    mx = t;
            }
            Console.WriteLine("Summer Practice! Yay!" + mid.ToString());
            Console.ReadKey();
        }
    }
}
