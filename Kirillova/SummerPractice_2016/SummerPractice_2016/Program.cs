using System;
using OpaqueFunctions;

namespace SummerPractice_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Summer Practice! Yay!");
            Console.WriteLine(СMath_1_2_ln.Math_1_2_ln(0.5, 15));
            Console.WriteLine(СMath_2_2_ln.Math_2_2_ln(10, 15));
            Console.WriteLine(СMath_3_2_ln.Math_3_2_ln(1, 15));
            Console.WriteLine(СMath_4_2_ln.Math_4_2_ln(1, 15));
            Console.WriteLine(СMath_5_2_ln.Math_5_2_ln(0.5, 15));
            Console.WriteLine(СMath_6_2_ln.Math_6_2_ln(2, 15));
            Console.WriteLine(СMath_7_3_ln.Math_7_3_ln(1.5,1.5, 15));
            Console.WriteLine(СMath_8_2_ln.Math_8_2_ln(0.5, 15));
            Console.WriteLine(СMath_9_2_ln.Math_9_2_ln(0.5, 15));
            Console.WriteLine(СMath_10_2_ln.Math_10_2_ln(0.5, 15));
            Console.WriteLine(СMath_11_2_ln.Math_11_2_ln(2, 15));

            Console.ReadKey();
        }
    }
}
