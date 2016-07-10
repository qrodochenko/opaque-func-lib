using System;
using OpaqueFunctions;

namespace SummerPractice_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Summer Practice! Yay!");
            Console.WriteLine();

            /*        Console.WriteLine(CMathApprox_1.MathApprox_1_1(-0.5));
                    Console.WriteLine(CMathApprox_1.MathApprox_1_1_Pow(-0.5));
                    Console.WriteLine(Math.Sin(-0.5));
                    Console.WriteLine();
                    Console.WriteLine(CMathApprox_1.MathApprox_1_1(-1.57));
                    Console.WriteLine(CMathApprox_1.MathApprox_1_1_Pow(-1.57));
                    Console.WriteLine(Math.Sin(-1.57));
                    Console.WriteLine();
            */

            int L = 6;
            int M = 6;

            double[] C = new double[L + M + 1];
            C[0] = 0;
            for (int i = 1; i < L + M + 1; i++)
                C[i] = 1.0 / i * Math.Pow(-1, i + 1);

            for (int i = 0; i < L + M + 1; i++)
                Console.WriteLine(C[i]);
            Console.WriteLine();


            Console.WriteLine(CMathApprox_Ln.MathApprox_ln_CheckError(L, M));
            Console.WriteLine(CMathApprox_Ln.MathApprox_ln_CheckError(5, 5));
            Console.WriteLine(CMathApprox_Ln.MathApprox_ln_4(0, 0.0005));
            Console.WriteLine(Math.Log(1));
            Console.WriteLine();


            Console.WriteLine(CMathApprox_1.MathApprox_1_1_in());
        }
    }
}
