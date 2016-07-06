using System;
using OpaqueFunctions;

namespace SummerPractice_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Summer Practice! Yay!");
            Console.WriteLine(С_Math_1_2_ln.Math_1_2_ln(0.5, 15));
            Console.WriteLine(С_Math_2_2_ln.Math_2_2_ln(1.5, 15));
            Console.WriteLine(С_Math_3_2_ln.Math_3_2_ln(0.5, 15));
            Console.WriteLine(С_Math_4_2_ln.Math_4_2_ln(1.5, 15));
            Console.WriteLine(С_Math_5_2_ln.Math_5_2_ln(1.5, 15));
            Console.WriteLine(С_Math_6_2_ln.Math_6_2_ln(1.5, 15));
          //  Console.WriteLine(С_Math_7_3_ln.Math_7_3_ln(0.5,1, 15));
            Console.ReadKey();
        }
    }
}
