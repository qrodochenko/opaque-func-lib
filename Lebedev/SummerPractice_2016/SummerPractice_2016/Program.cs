using System;
using OpaqueFunctions;

namespace SummerPractice_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i < 99; i++)
            {
                double dx = 1.0 / 100.0;
                double x = -1 + i * dx;
                double F = CMath_12_2.Math_12_2(x, 100);
                double benchmark = Math.Pow(1 - x, -3);
                double error = Math.Abs(F - benchmark);
                Console.WriteLine(x.ToString() + ' ' + error.ToString());
            }
            
            Console.ReadKey();
        }
    }
}

