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

            Console.WriteLine("Taylor coefficients: ");
            for (int i = 0; i < L + M + 1; i++)
                Console.Write(C[i] + " ");
            Console.WriteLine();
            Console.WriteLine();

            double[] Ln_Numer = new double[L + 1];
            double[] Ln_Denom = new double[M + 1];

            CFind_Pade.Find_Denominator(Ln_Denom, C, L, M);
            CFind_Pade.Find_Numerator(Ln_Numer, Ln_Denom, C, L, M);

            Console.WriteLine("Ln(1 + x) denominator:");
            for (int i = 0; i < M + 1; i++)
            {
                Console.Write(Ln_Denom[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(CMathApprox_Ln.MathApprox_ln_CheckError(L, M));
            Console.WriteLine(CMathApprox_Ln.MathApprox_ln_CheckError(2, 2));
            Console.WriteLine(CMathApprox_Ln.MathApprox_ln_CheckError(1, 1));
            Console.WriteLine();

            Random rnd = new Random();
            double error = 0.000000000001;
            double max = 0.0;
            for (int i = 0; i < 1000; i++)
            {
                double arg = rnd.Next(1, 2000) - 1000;
                arg = arg / 2000.0;
                if (Math.Abs(arg) > max)
                    max = Math.Abs(arg);
                if (Math.Abs(CMathApprox_Ln.MathApprox_ln_2(arg, error) - Math.Log(arg + 1)) > error)
                    Console.Write("lol noob ");
            }
            Console.WriteLine(max);
            Console.WriteLine();
            Console.WriteLine(CMathApprox_Ln.MathApprox_ln_2(0.5, 0.0000000000001));
            Console.WriteLine(Math.Log(1.5));
            Console.WriteLine();


            Console.WriteLine(CMathApprox_1.MathApprox_1_1_in());

        }
    }
}
