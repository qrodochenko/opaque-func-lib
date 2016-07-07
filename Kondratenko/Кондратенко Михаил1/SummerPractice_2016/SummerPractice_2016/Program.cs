using System;

namespace SummerPractice_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Summer Practice! Yay!");
            Console.ReadKey();
            double N = 10000000;
            double K = 0;
            double L = 0;
            for (double i = 1; i < N; i++)
            {
                K += 1/i;

            }
            Console.WriteLine(K);
            for (double i = 1; i <= N; i++)
            {
                L = L + 1/(N - i + 1);

            }
            Console.WriteLine(L);
            Main1();
            Console.ReadKey();



        }

        static void Main1()

        {
            Console.WriteLine("Summer Practice! Yay!");
            Console.ReadKey();
            float N = 10000000;
            float K = 0;
            float L = 0;
            for (float i = 1; i <= N; i++)
            {
                K = K + 1 / i;

            }
            Console.WriteLine(K);
            for (float i = 1; i <= N; i++)
            {
                L = L + 1/(N - i + 1);

            }
            Console.WriteLine(L);







        }
    }
}
