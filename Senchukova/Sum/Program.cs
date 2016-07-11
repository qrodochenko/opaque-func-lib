using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            long int N = 10000000;
            float S1 = 0;
            double S2 = 0;

            for (int i = 1; i <= N; i++)
            {
                S1 += 1 / i;
                S2 += 1 / i;
            }

            Console.WriteLine(S1);
            Console.WriteLine(S2);
            Console.ReadKey();

        }

    }
}
