using System;
using OpaqueFunctions;

namespace SummerPractice_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 1; i < 99; i++)
            //{
                //double dx = 1.0 / 100.0;
                //double x = -1 + i * dx;
                //double F = CMath_12_2.Math_12_2(x, 100);
                System.IO.StreamWriter file = 
                    new System.IO.StreamWriter(@"D:\Student\1\WriteLines2.csv");
                file.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
                for (int i = 1; i < 200; i++)
                {
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;                                                                            
                    double F = CMath_1_2.Math_1_2(x, 100);
                    double benchmark = Math.Pow(1.0 + x, (1.0 / 3.0));
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    double eps = 0.0000000001;
                    
                    //Assert.IsTrue(error < Double.Epsilon, "Погрешность больше нужной!")
                    //if (error < eps) //Double.Epsilon
                    // {

                    file.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                    
                    //Console.WriteLine(x.ToString() + ' ' + absoluteError.ToString());
                    // }
                }
                file.Close();

            //double niw = Math.Pow(3, -1) * 4;
            //double niw = 3 * Math.Pow(4, -1);
           // Console.WriteLine(niw);
            Console.ReadKey();

        }
            
            
        }
    
}

