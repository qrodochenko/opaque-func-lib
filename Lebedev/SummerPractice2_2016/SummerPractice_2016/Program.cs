using System;
using OpaqueFunctions;
using System.Collections.Generic;
using System.Linq; 
namespace SummerPractice_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 1000;
            MakeResultsSummaryFile("Math_1_2", CMath_1_2.Math_1_2, N);
            MakeResultsSummaryFile("Math_2_2", CMath_2_2.Math_2_2, N);
            MakeResultsSummaryFile("Math_3_2", CMath_3_2.Math_3_2, N);
            MakeResultsSummaryFile("Math_4_2", CMath_4_2.Math_4_2, N);
            MakeResultsSummaryFile("Math_5_2", CMath_5_2.Math_5_2, N);
            MakeResultsSummaryFile("Math_6_2", CMath_6_2.Math_6_2, N);
            MakeResultsSummaryFile("Math_7_2", CMath_7_2.Math_7_2, N);
            MakeResultsSummaryFile("Math_8_2", CMath_8_2.Math_8_2, N);
            MakeResultsSummaryFile("Math_9_2", CMath_9_2.Math_9_2, N);
            MakeResultsSummaryFile("Math_10_2", CMath_10_2.Math_10_2, N);
            MakeResultsSummaryFile("Math_11_2", CMath_11_2.Math_11_2, N);
            MakeResultsSummaryFile("Math_12_2", CMath_12_2.Math_12_2, N);
            MakeResultsSummaryFile("Math_13_2", CMath_13_2.Math_13_2, N);
            MakeResultsSummaryFile("Math_14_2", CMath_14_2.Math_14_2, N);
            MakeResultsSummaryFile("Math_15_2", CMath_15_2.Math_15_2, N);
            MakeResultsSummaryFile("Math_16_2", CMath_16_2.Math_16_2, N);
            MakeResultsSummaryFile("Math_17_2", CMath_17_2.Math_17_2, N);
            MakeResultsSummaryFile("Math_18_2", CMath_18_2.Math_18_2, N);
            MakeResultsSummaryFile("Math_19_2", CMath_19_2.Math_19_2, N);
            MakeResultsSummaryFile("Math_10_2", CMath_20_2.Math_20_2, N);

           
        }

        static void MakeResultsSummaryFile(string funcname, Func<double,int,double> f, int N)
        {
            string dest_folder = ("csv\\");
            string dest = dest_folder + funcname + "_N" + N.ToString() + ".csv";
            System.IO.StreamWriter dest_file_writer =
               new System.IO.StreamWriter(dest);
            dest_file_writer.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "computation time (milliseconds)");
            double left_border_of_range = -1.0;
            double right_border_of_range = 1.0;
            double range_length = Math.Abs(right_border_of_range - left_border_of_range);
            uint number_of_points = 200;
            double dx = range_length / number_of_points;
            for (int i = 1; i < number_of_points; i++)
            {
                System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // создаем объект
                swatch.Start();
                double x = left_border_of_range + i * dx;
                double F = f(x, N);
                double benchmark = Math.Pow(1.0 + x, (1.0 / 3.0));
                double absoluteError = Math.Abs((F - benchmark));
                double relativeError = Math.Abs((F - benchmark) / benchmark);
                swatch.Stop();
                long t = swatch.ElapsedMilliseconds;
                dest_file_writer.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());                                                     
            }
            //file1.WriteLine(';' + ';' + ';' + l.Min().ToString() + l.Max().ToString() + l.Average().ToString());
            //Console.Write(String.Format("{0,5} {1,5} {2,5}",l.Average(), l.Max(), l.Min()));
            Console.Write("Complete! /n");          
            dest_file_writer.Close();
        }            
        }
    
}

