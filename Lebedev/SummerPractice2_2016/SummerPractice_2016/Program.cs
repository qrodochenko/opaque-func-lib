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
                System.IO.StreamWriter file1 =
                    //new System.IO.StreamWriter(@"D:\Student\1\csv\Math_1_2.csv");
                    new System.IO.StreamWriter(@"csv\Math_1_2.csv");
            file1.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
                for (int i = 1; i < 200; i++)
                {
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;                                                                            
                    double F = CMath_1_2.Math_1_2(x, 100);
                    double benchmark = Math.Pow(1.0 + x, (1.0 / 3.0));
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);                    
                    file1.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());                    

                    //Assert.IsTrue(error < Double.Epsilon, "Погрешность больше нужной!")
                    
                }
                file1.Close();

                    //------------



                System.IO.StreamWriter file2 = 
                new System.IO.StreamWriter(@"csv\Math_2_2.csv");
                file2.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
                for (int i = 1; i < 200; i++)
                {
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;                                                                                                                   
                    double F = CMath_2_2.Math_2_2(x, 100);                                        
                    double benchmark = Math.Pow(1.0 - x, (1.0 / 3.0));
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);                    
                    file2.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                double eps = 0.0000000001;
                if (absoluteError < eps) //Double.Epsilon
                {
                    Console.WriteLine(x.ToString() + ' ' + absoluteError.ToString());
                }


            }
                file2.Close();



                System.IO.StreamWriter file3 =
                    new System.IO.StreamWriter(@"csv\Math_3_2.csv");
                file3.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
                for (int i = 1; i < 200; i++)
                {
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_3_2.Math_3_2(x, 100);
                    double benchmark = Math.Pow(1.0 + x, (1.0 / 2.0));
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    file3.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
               
            }
                file3.Close();


                System.IO.StreamWriter file4 =
                        new System.IO.StreamWriter(@"csv\Math_4_2.csv");
                file4.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
                for (int i = 1; i < 200; i++)
                {
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_4_2.Math_4_2(x, 100);
                    double benchmark = Math.Pow(1.0 - x, (1.0 / 2.0));
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    file4.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                
            }
                file4.Close();

                System.IO.StreamWriter file5 =
                            new System.IO.StreamWriter(@"csv\Math_5_2.csv");
                file5.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
                for (int i = 1; i < 200; i++)
                {
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_5_2.Math_5_2(x, 100);
                    double benchmark = Math.Pow(1.0 + x, (1.0 / 4.0));
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    file5.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                
            }
                file5.Close();


                System.IO.StreamWriter file6 =
                            new System.IO.StreamWriter(@"csv\Math_6_2.csv");
                file6.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
                for (int i = 1; i < 200; i++)
                {
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_6_2.Math_6_2(x, 100);
                    double benchmark = Math.Pow(1.0 - x, (1.0 / 4.0));
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    file6.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                
            }
                file6.Close();

                System.IO.StreamWriter file7 =
                            new System.IO.StreamWriter(@"csv\Math_7_2.csv");
                file7.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
                for (int i = 1; i < 200; i++)
                {
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_7_2.Math_7_2(x, 100);
                    double benchmark = Math.Pow(1.0 + x, -1);
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    file7.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                
            }
                file7.Close();

                System.IO.StreamWriter file8 =
                            new System.IO.StreamWriter(@"csv\Math_8_2.csv");
                file8.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
                for (int i = 1; i < 200; i++)
                {
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_8_2.Math_8_2(x, 100);
                    double benchmark = Math.Pow(1.0 - x, -1);
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    file8.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                
            }
                file8.Close();

                System.IO.StreamWriter file9 =
                            new System.IO.StreamWriter(@"csv\Math_9_2.csv");
                file9.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
                for (int i = 1; i < 200; i++)
                {
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_9_2.Math_9_2(x, 100);
                    double benchmark = Math.Pow(1.0 + x, -2);
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    file9.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                
            }
                file9.Close();

                System.IO.StreamWriter file10 =
                            new System.IO.StreamWriter(@"csv\Math_10_2.csv");
                file10.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
                for (int i = 1; i < 200; i++)
                {
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_10_2.Math_10_2(x, 100);
                    double benchmark = Math.Pow(1.0 - x, -2);
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    file10.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                
            }
                file10.Close();

                System.IO.StreamWriter file11 =
                            new System.IO.StreamWriter(@"csv\Math_11_2.csv");
                file11.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
                for (int i = 1; i < 200; i++)
                {
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_11_2.Math_11_2(x, 100);
                    double benchmark = Math.Pow(1.0 + x, -3);
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    file11.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                
            }
                file11.Close();              

                System.IO.StreamWriter file12 =
                            new System.IO.StreamWriter(@"csv\Math_12_2.csv");
                file12.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
                for (int i = 1; i < 200; i++)
                {
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_12_2.Math_12_2(x, 100);
                    double benchmark = Math.Pow(1.0 - x, -3);
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    file12.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                
            }
                file12.Close();

                System.IO.StreamWriter file13 =
                            new System.IO.StreamWriter(@"csv\Math_13_2.csv");
                file13.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
                for (int i = 1; i < 200; i++)
                {
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_13_2.Math_13_2(x, 100);
                    double benchmark = Math.Pow(1.0 + x, -4);
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    file13.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
               
            }
                file13.Close();

                System.IO.StreamWriter file14 =
                            new System.IO.StreamWriter(@"csv\Math_14_2.csv");
                file14.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
                for (int i = 1; i < 200; i++)
                {
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_14_2.Math_14_2(x, 100);
                    double benchmark = Math.Pow(1.0 - x, -4);
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    file14.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                
            }
                file14.Close();

                System.IO.StreamWriter file15 =
                            new System.IO.StreamWriter(@"csv\Math_15_2.csv");
                file15.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
                for (int i = 1; i < 200; i++)
                {
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_15_2.Math_15_2(x, 100);
                    double benchmark = Math.Pow(1.0 + x, (-1.0 / 2.0));
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    file15.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                
            }
                file15.Close();

                System.IO.StreamWriter file16 =
                            new System.IO.StreamWriter(@"csv\Math_16_2.csv");
                file16.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
                for (int i = 1; i < 200; i++)
                {
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_16_2.Math_16_2(x, 100);
                    double benchmark = Math.Pow(1.0 - x, (-1.0 / 2.0));
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    file16.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                          
            }
                file16.Close();

                System.IO.StreamWriter file17 =
                            new System.IO.StreamWriter(@"csv\Math_17_2.csv");
                file17.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
                for (int i = 1; i < 200; i++)
                {
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_17_2.Math_17_2(x, 100);
                    double benchmark = Math.Pow(1.0 + x, (-1.0 / 3.0));
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    file17.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                
            }
                file17.Close();

                System.IO.StreamWriter file18 =
                            new System.IO.StreamWriter(@"csv\Math_18_2.csv");
                file18.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
                for (int i = 1; i < 200; i++)
                {
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_18_2.Math_18_2(x, 100);
                    double benchmark = Math.Pow(1.0 - x, (-1.0 / 3.0));
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    file18.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                
            }
                file18.Close();

                System.IO.StreamWriter file19 =
                                new System.IO.StreamWriter(@"csv\Math_19_2.csv");
                file19.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
                for (int i = 1; i < 200; i++)
                {
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_19_2.Math_19_2(x, 100);
                    double benchmark = Math.Pow(1.0 + x, (-1.0 / 4.0));
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    file19.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                
            }
                file19.Close();

                System.IO.StreamWriter file20 =
                                new System.IO.StreamWriter(@"csv\Math_20_2.csv");
                file20.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError");
                for (int i = 1; i < 200; i++)
                {
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_20_2.Math_20_2(x, 100);
                    double benchmark = Math.Pow(1.0 - x, (-1.0 / 4.0));
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    file20.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());
                
            }
                file20.Close();

            //double niw = Math.Pow(3, -1) * 4;
            //double niw = 3 * Math.Pow(4, -1);
           // Console.WriteLine(niw);
            Console.ReadKey();

        }
            
            
        }
    
}

