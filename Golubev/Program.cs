using System;
using OpaqueFunctions;

namespace SummerPractice_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Summer Practice! Yay!");
            OpaqueFunctions.C_priv_sin_3.Solve k = OpaqueFunctions.C_priv_sin_3.priv_sin_3( Math.PI / 3);
            Console.WriteLine(k.sign+k.function+"("+k.argument+")");
            Console.ReadKey();
        }
    }
}
