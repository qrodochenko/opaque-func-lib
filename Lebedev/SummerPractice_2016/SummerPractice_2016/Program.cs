using System;
using OpaqueFunctions;

namespace SummerPractice_2016
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int n = 100; n < 10000; n += 500)
            {
                for (int i = 0; i<10; i++)
                {
                    double dx = 2.0 / 10.0;
                    double x = -1 + (i + 1) * dx;
                    double F = CMath_7_2.Math_7_2(x, n);
                    double benchmark = Math.Pow(1 + x, -1);
                    double error1 = Math.Abs(F - benchmark);
                    double error = Math.Abs(F - benchmark) / benchmark;
                    Console.WriteLine(n.ToString() + ' ' + x.ToString() + ' ' + error1 + ' ' + error);
                }
                
            }
            Console.WriteLine("Summer Practice! Yay!");
            Console.ReadKey();
        }
    }
}

