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
            //for (int i = 1; i < 99; i++)
            //{
                //double dx = 1.0 / 100.0;
                //double x = -1 + i * dx;
                //double F = CMath_12_2.Math_12_2(x, 100);



            MakeResultsSummaryFile("Math_1_2", CMath_1_2.Math_1_2, 100);

/*                System.IO.StreamWriter file1 =
                    //new System.IO.StreamWriter(@"D:\Student\1\csv\Math_1_2.csv");
                    new System.IO.StreamWriter(@"csv\Math_1_2.csv");
                file1.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "computation time (milliseconds)");
            //var l = new List<long>();
                for (int i = 1; i < 200; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // создаем объект
                    swatch.Start();
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;                                                                            
                    double F = CMath_1_2.Math_1_2(x, 10000);
                    double benchmark = Math.Pow(1.0 + x, (1.0 / 3.0));
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;                    
                    file1.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());                                        
                    //l.Add(swatch.ElapsedMilliseconds);
                    //Console.WriteLine(swatch.ElapsedMilliseconds); // выводим результат в консоль                    
                    //Assert.IsTrue(error < Double.Epsilon, "Погрешность больше нужной!")                                       
                }                
                //file1.WriteLine(';' + ';' + ';' + l.Min().ToString() + l.Max().ToString() + l.Average().ToString());
                //Console.Write(String.Format("{0,5} {1,5} {2,5}",l.Average(), l.Max(), l.Min()));
                Console.Write("Complete!");
                file1.Close();
                
*/               

                    //------------



                System.IO.StreamWriter file2 = 
                new System.IO.StreamWriter(@"csv\Math_2_2.csv");
                file2.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "time");
                for (int i = 1; i < 200; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // создаем объект
                    swatch.Start();
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;                                                                                                                   
                    double F = CMath_2_2.Math_2_2(x, 1000);                                        
                    double benchmark = Math.Pow(1.0 - x, (1.0 / 3.0));
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    file2.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());                                        
                double eps = 0.0000000001;
                if (absoluteError < Double.Epsilon) //Double.Epsilon
                {
                  // Console.WriteLine(x.ToString() + ' ' + absoluteError.ToString());
                }


            }
                file2.Close();



                System.IO.StreamWriter file3 =
                    new System.IO.StreamWriter(@"csv\Math_3_2.csv");
                file3.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "time");
                for (int i = 1; i < 200; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // создаем объект
                    swatch.Start();
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_3_2.Math_3_2(x, 100);
                    double benchmark = Math.Pow(1.0 + x, (1.0 / 2.0));
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    file3.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());                                        
               
            }
                file3.Close();


                System.IO.StreamWriter file4 =
                        new System.IO.StreamWriter(@"csv\Math_4_2.csv");
                file4.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "time");
                for (int i = 1; i < 200; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // создаем объект
                    swatch.Start();
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_4_2.Math_4_2(x, 100);
                    double benchmark = Math.Pow(1.0 - x, (1.0 / 2.0));
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    file4.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());                                        
                
            }
                file4.Close();

                System.IO.StreamWriter file5 =
                            new System.IO.StreamWriter(@"csv\Math_5_2.csv");
                file5.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "time");
                for (int i = 1; i < 200; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // создаем объект
                    swatch.Start();
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_5_2.Math_5_2(x, 100);
                    double benchmark = Math.Pow(1.0 + x, (1.0 / 4.0));
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    file5.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());                                        
                
            }
                file5.Close();


                System.IO.StreamWriter file6 =
                            new System.IO.StreamWriter(@"csv\Math_6_2.csv");
                file6.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "time");
                for (int i = 1; i < 200; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // создаем объект
                    swatch.Start();
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_6_2.Math_6_2(x, 100);
                    double benchmark = Math.Pow(1.0 - x, (1.0 / 4.0));
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    file6.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());                                        
                
            }
                file6.Close();

                System.IO.StreamWriter file7 =
                            new System.IO.StreamWriter(@"csv\Math_7_2.csv");
                file7.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "time");
                for (int i = 1; i < 200; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // создаем объект
                    swatch.Start();
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_7_2.Math_7_2(x, 100);
                    double benchmark = Math.Pow(1.0 + x, -1);
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    file7.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());                                        
                
            }
                file7.Close();

                System.IO.StreamWriter file8 =
                            new System.IO.StreamWriter(@"csv\Math_8_2.csv");
                file8.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "time");
                for (int i = 1; i < 200; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // создаем объект
                    swatch.Start();
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_8_2.Math_8_2(x, 100);
                    double benchmark = Math.Pow(1.0 - x, -1);
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    file8.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());                                        
                
            }
                file8.Close();

                System.IO.StreamWriter file9 =
                            new System.IO.StreamWriter(@"csv\Math_9_2.csv");
                file9.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "time");
                for (int i = 1; i < 200; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // создаем объект
                    swatch.Start();
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_9_2.Math_9_2(x, 100);
                    double benchmark = Math.Pow(1.0 + x, -2);
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    file9.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());                                        
                
            }
                file9.Close();

                System.IO.StreamWriter file10 =
                            new System.IO.StreamWriter(@"csv\Math_10_2.csv");
                file10.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "time");
                for (int i = 1; i < 200; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // создаем объект
                    swatch.Start();
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_10_2.Math_10_2(x, 100);
                    double benchmark = Math.Pow(1.0 - x, -2);
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    file10.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());                                        
                
            }
                file10.Close();

                System.IO.StreamWriter file11 =
                            new System.IO.StreamWriter(@"csv\Math_11_2.csv");
                file11.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "time");
                for (int i = 1; i < 200; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // создаем объект
                    swatch.Start();
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_11_2.Math_11_2(x, 100);
                    double benchmark = Math.Pow(1.0 + x, -3);
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    file11.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());                                        
                
            }
                file11.Close();              

                System.IO.StreamWriter file12 =
                            new System.IO.StreamWriter(@"csv\Math_12_2.csv");
                file12.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "time");
                for (int i = 1; i < 200; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // создаем объект
                    swatch.Start();
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_12_2.Math_12_2(x, 100);
                    double benchmark = Math.Pow(1.0 - x, -3);
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    file12.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());                                        
                
            }
                file12.Close();

                System.IO.StreamWriter file13 =
                            new System.IO.StreamWriter(@"csv\Math_13_2.csv");
                file13.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "time");
                for (int i = 1; i < 200; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // создаем объект
                    swatch.Start();
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_13_2.Math_13_2(x, 100);
                    double benchmark = Math.Pow(1.0 + x, -4);
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    file13.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());                                        
               
            }
                file13.Close();

                System.IO.StreamWriter file14 =
                            new System.IO.StreamWriter(@"csv\Math_14_2.csv");
                file14.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "time");
                for (int i = 1; i < 200; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // создаем объект
                    swatch.Start();
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_14_2.Math_14_2(x, 100);
                    double benchmark = Math.Pow(1.0 - x, -4);
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    file14.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());                                        
                
            }
                file14.Close();

                System.IO.StreamWriter file15 =
                            new System.IO.StreamWriter(@"csv\Math_15_2.csv");
                file15.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "time");
                for (int i = 1; i < 200; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // создаем объект
                    swatch.Start();
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_15_2.Math_15_2(x, 100);
                    double benchmark = Math.Pow(1.0 + x, (-1.0 / 2.0));
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    file15.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());                                        
                
            }
                file15.Close();

                System.IO.StreamWriter file16 =
                            new System.IO.StreamWriter(@"csv\Math_16_2.csv");
                file16.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "time");
                for (int i = 1; i < 200; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // создаем объект
                    swatch.Start();
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_16_2.Math_16_2(x, 100);
                    double benchmark = Math.Pow(1.0 - x, (-1.0 / 2.0));
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    file16.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());                                        
                          
            }
                file16.Close();

                System.IO.StreamWriter file17 =
                            new System.IO.StreamWriter(@"csv\Math_17_2.csv");
                file17.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "time");
                for (int i = 1; i < 200; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // создаем объект
                    swatch.Start();
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_17_2.Math_17_2(x, 100);
                    double benchmark = Math.Pow(1.0 + x, (-1.0 / 3.0));
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    file17.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());                                        
                
            }
                file17.Close();

                System.IO.StreamWriter file18 =
                            new System.IO.StreamWriter(@"csv\Math_18_2.csv");
                file18.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "time");
                for (int i = 1; i < 200; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // создаем объект
                    swatch.Start();
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_18_2.Math_18_2(x, 100);
                    double benchmark = Math.Pow(1.0 - x, (-1.0 / 3.0));
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    file18.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());                                        
                
            }
                file18.Close();

                System.IO.StreamWriter file19 =
                                new System.IO.StreamWriter(@"csv\Math_19_2.csv");
                file19.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "time");
                for (int i = 1; i < 200; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // создаем объект
                    swatch.Start();
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_19_2.Math_19_2(x, 100);
                    double benchmark = Math.Pow(1.0 + x, (-1.0 / 4.0));
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    file19.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());                                        
                
            }
                file19.Close();

                System.IO.StreamWriter file20 =
                                new System.IO.StreamWriter(@"csv\Math_20_2.csv");
                file20.WriteLine("x" + ';' + "absoluteError" + ';' + "relativeError" + ';' + "time");
                for (int i = 1; i < 200; i++)
                {
                    System.Diagnostics.Stopwatch swatch = new System.Diagnostics.Stopwatch(); // создаем объект
                    swatch.Start();
                    double dx = 1.0 / 100.0;
                    double x = -1 + i * dx;
                    double F = CMath_20_2.Math_20_2(x, 100);
                    double benchmark = Math.Pow(1.0 - x, (-1.0 / 4.0));
                    double absoluteError = Math.Abs((F - benchmark));
                    double relativeError = Math.Abs((F - benchmark) / benchmark);
                    swatch.Stop();
                    long t = swatch.ElapsedMilliseconds;
                    file20.WriteLine(x.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString() + ';' + t.ToString());                                        
                
            }
                file20.Close();

            //double niw = Math.Pow(3, -1) * 4;
            //double niw = 3 * Math.Pow(4, -1);
           // Console.WriteLine(niw);
            Console.ReadKey();

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
                //l.Add(swatch.ElapsedMilliseconds);
                //Console.WriteLine(swatch.ElapsedMilliseconds); // выводим результат в консоль                    
                //Assert.IsTrue(error < Double.Epsilon, "Погрешность больше нужной!")                                       
            }
            //file1.WriteLine(';' + ';' + ';' + l.Min().ToString() + l.Max().ToString() + l.Average().ToString());
            //Console.Write(String.Format("{0,5} {1,5} {2,5}",l.Average(), l.Max(), l.Min()));
            Console.Write("Complete!");
            dest_file_writer.Close();
        }
            
        }
    
}

