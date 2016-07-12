#define DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpaqueFunctions;

namespace SummerPractice_2016
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Задание:
            /// Если область определения конечна (интервал), то берется из интервала k=10 точек, 
            /// в этих точках вычисляется функция и вычисляются ее среднее и максимальное значения. 
            /// Результаты сравниваются с допустимой погрешностью и в негативном случае выводятся на экран. 


            double max = 0;
            double average = 0;
            double sum = 0;

            Random R = new Random();

            int i = 1, p = 1;
            double x, g, g_inv;
            double C, a, b, c, d;



            Console.WriteLine("g_inv(x) = sqrt(C) * x / sqrt(1 - x*x), x in (-1, 1)");
            x = p * R.NextDouble();
            C = R.NextDouble();
            p *= -1;

            g = Cinterval_ww_finfin_2_inv.interval_ww_finfin_2_inv(x, C);
            max = g;
            sum = g;

            for (i = 2; i <= 10; i++)
            {
                x = R.NextDouble();
                C = R.NextDouble();

                g = Cinterval_ww_finfin_2_inv.interval_ww_finfin_2_inv(x, C);

                if (g > max) max = g;
                sum += g;

                //    Console.WriteLine("x = " + x);
                //    Console.WriteLine("g(x) = " + g);

            }

            average = sum / 10.0;
            //  Console.WriteLine();
            if (Math.Abs(max - average) < 0.000001)
                Console.WriteLine("Results are almost equal");

            Console.WriteLine("Average = " + average);
            Console.WriteLine("Max = " + max);

            Console.WriteLine();




            max = sum = average = 0;
            Console.WriteLine("g(x) = tg(x), x in (-Pi/2, Pi/2)");
            x = p * R.NextDouble() * Math.PI / 2;
            p *= -1;

            g = Cinterval_finfin_ww_3.interval_finfin_ww_3(x);
            max = g;
            sum = g;

            for (i = 2; i <= 10; i++)
            {
                x = p * R.NextDouble() * Math.PI / 2;
                p *= -1;

                g = Cinterval_finfin_ww_3.interval_finfin_ww_3(x);
                if (g > max) max = g;
                sum += g;

                //    Console.WriteLine("x = " + x);
                //    Console.WriteLine("g(x) = " + g);

            }

            average = sum / 10.0;
            //  Console.WriteLine();
            if (Math.Abs(max - average) < 0.000001)
                Console.WriteLine("Results are almost equal");

            Console.WriteLine("Average = " + average);
            Console.WriteLine("Max = " + max);

            Console.WriteLine();




            max = sum = average = 0;
            i = 1; 
            Console.WriteLine("g(x) = ((c - d)/(a - b)) * x + (a*d - b*c) / (a - b), x in (a, b)");

            a = R.Next(1, 10) + R.NextDouble();
            b = a + R.Next(2, 10) + R.NextDouble();
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            x = a + R.NextDouble();

            c = R.Next(1, 10) + R.NextDouble();
            d = c + R.Next(2, 10) + R.NextDouble();

            g = Cinterval_finfin_finfin_7.interval_finfin_finfin_7(x, a, b, c, d);
            max = g;
            sum = g;

            for (i = 2; i <= 10; i++)
            {
                x = a + R.NextDouble();
                g = Cinterval_finfin_finfin_7.interval_finfin_finfin_7(x, a, b, c, d);

                if (g > max) max = g;
                sum += g;

                 //  Console.WriteLine("x = " + x);
                 //  Console.WriteLine("g(x) = " + g);

            }

            average = sum / 10.0;
             // Console.WriteLine();
            if (Math.Abs(max - average) < 0.000001)
                Console.WriteLine("Results are almost equal");

            Console.WriteLine("Average = " + average);
            Console.WriteLine("Max = " + max);

            Console.WriteLine();




            max = sum = average = 0;
            i = 1;
            Console.WriteLine("g_inv(x) = ((a - b)/(c -d)) * x + (bc - ad) / (c - d), x in (c, d)");

            a = R.Next(1, 10) + R.NextDouble();
            b = a + R.Next(2, 10) + R.NextDouble();

            c = R.Next(1, 10) + R.NextDouble();
            d = c + R.Next(2, 10) + R.NextDouble();
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);
            x = c + R.NextDouble();

            g = Cinterval_finfin_finfin_7_inv.interval_finfin_finfin_7_inv(x, a, b, c, d);
            max = g;
            sum = g;

            for (i = 2; i <= 10; i++)
            {

                x = c + R.NextDouble();
                g = Cinterval_finfin_finfin_7_inv.interval_finfin_finfin_7_inv(x, a, b, c, d);


                if (g > max) max = g;
                sum += g;

                //    Console.WriteLine("x = " + x);
                //    Console.WriteLine("g(x) = " + g);

            }

            average = sum / 10.0;
            //  Console.WriteLine();
            if (Math.Abs(max - average) < 0.000001)
                Console.WriteLine("Results are almost equal");

            Console.WriteLine("Average = " + average);
            Console.WriteLine("Max = " + max);

            Console.WriteLine();




            max = sum = average = 0;
            i = 1;
            Console.WriteLine("g(x) = (ab*(d - c)/(a - b)) / x + (ac - bd) / (a - b), x in (a, b)");

            a = R.Next(1, 10) + R.NextDouble();
            b = a + R.Next(2, 10) + R.NextDouble();
            x = a + R.NextDouble();
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            c = R.Next(1, 10) + R.NextDouble();
            d = c + R.Next(2, 10) + R.NextDouble();

            g = Cinterval_finfin_finfin_8.interval_finfin_finfin_8(x, a, b, c, d);
            max = g;
            sum = g;

            for (i = 2; i <= 10; i++)
            {

                x = a + R.NextDouble();
                g = Cinterval_finfin_finfin_8.interval_finfin_finfin_8(x, a, b, c, d);


                if (g > max) max = g;
                sum += g;

                //    Console.WriteLine("x = " + x);
                //    Console.WriteLine("g(x) = " + g);

            }

            average = sum / 10.0;
            //  Console.WriteLine();
            if (Math.Abs(max - average) < 0.000001)
                Console.WriteLine("Results are almost equal");

            Console.WriteLine("Average = " + average);
            Console.WriteLine("Max = " + max);

            Console.WriteLine();




            max = sum = average = 0;
            i = 1;
            Console.WriteLine("g_inv(x) = (d - c)*a*b/(x*(a- b) - (a*c - b*d)), x in (c, d)");

            a = R.Next(1, 10) + R.NextDouble();
            b = a + R.Next(2, 10) + R.NextDouble();

            c = R.Next(1, 10) + R.NextDouble();
            d = c + R.Next(2, 10) + R.NextDouble();
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);
            x = c + R.NextDouble();


            g = Cinterval_finfin_finfin_8_inv.interval_finfin_finfin_8_inv(x, a, b, c, d);
            max = g;
            sum = g;

            for (i = 2; i <= 10; i++)
            {

                x = c + R.NextDouble();
                g = Cinterval_finfin_finfin_8_inv.interval_finfin_finfin_8_inv(x, a, b, c, d);


                if (g > max) max = g;
                sum += g;

                //    Console.WriteLine("x = " + x);
                //    Console.WriteLine("g(x) = " + g);

            }

            average = sum / 10.0;
            //  Console.WriteLine();
            if (Math.Abs(max - average) < 0.000001)
                Console.WriteLine("Results are almost equal");

            Console.WriteLine("Average = " + average);
            Console.WriteLine("Max = " + max);

            Console.WriteLine();

            



            max = sum = average = 0;
            Console.WriteLine("g(x) = sin(x), x in (-Pi/2, Pi/2)");
            x = p * R.NextDouble() * Math.PI / 2;
            p *= -1;

            g = Cinterval_finfin_finfin_9.interval_finfin_finfin_9(x);
            max = g;
            sum = g;

            for (i = 2; i <= 10; i++)
            {
                x = p * R.NextDouble() * Math.PI / 2;
                p *= -1;

                g = Cinterval_finfin_finfin_9.interval_finfin_finfin_9(x);
                if (g > max) max = g;
                sum += g;

                //    Console.WriteLine("x = " + x);
                //    Console.WriteLine("g(x) = " + g);

            }

            average = sum / 10.0;
            //  Console.WriteLine();
            if (Math.Abs(max - average) < 0.000001)
                Console.WriteLine("Results are almost equal");

            Console.WriteLine("Average = " + average);
            Console.WriteLine("Max = " + max);

            Console.WriteLine();




            max = sum = average = 0;
            Console.WriteLine("g(x) = arcsin(x), x in (-1, 1)");
            x = p * R.NextDouble();
            p *= -1;

            g = Cinterval_finfin_finfin_9_inv.interval_finfin_finfin_9_inv(x);
            max = g;
            sum = g;

            for (i = 2; i <= 10; i++)
            {
                x = p * R.NextDouble();
                p *= -1;

                g = Cinterval_finfin_finfin_9_inv.interval_finfin_finfin_9_inv(x);
                if (g > max) max = g;
                sum += g;

                //    Console.WriteLine("x = " + x);
                //    Console.WriteLine("g(x) = " + g);

            }

            average = sum / 10.0;
            //  Console.WriteLine();
            if (Math.Abs(max - average) < 0.000001)
                Console.WriteLine("Results are almost equal");

            Console.WriteLine("Average = " + average);
            Console.WriteLine("Max = " + max);

            Console.WriteLine();





            max = sum = average = 0;
            Console.WriteLine("g(x) = cos(x), x in (0, Pi)");
            x = R.NextDouble() * Math.PI ;

            g = Cinterval_finfin_finfin_10.interval_finfin_finfin_10(x);
            max = g;
            sum = g;

            for (i = 2; i <= 10; i++)
            {
                x = R.NextDouble() * Math.PI;

                g = Cinterval_finfin_finfin_10.interval_finfin_finfin_10(x);
                if (g > max) max = g;
                sum += g;

                //    Console.WriteLine("x = " + x);
                //    Console.WriteLine("g(x) = " + g);

            }

            average = sum / 10.0;
            //  Console.WriteLine();
            if (Math.Abs(max - average) < 0.000001)
                Console.WriteLine("Results are almost equal");

            Console.WriteLine("Average = " + average);
            Console.WriteLine("Max = " + max);

            Console.WriteLine();




            max = sum = average = 0;
            Console.WriteLine("g(x) = arccos(x), x in (-1, 1)");
            x = p * R.NextDouble() ;
            p *= -1;

            g = Cinterval_finfin_finfin_10_inv.interval_finfin_finfin_10_inv(x);
            max = g;
            sum = g;

            for (i = 2; i <= 10; i++)
            {
                x = p * R.NextDouble();
                p *= -1;

                g = Cinterval_finfin_finfin_10_inv.interval_finfin_finfin_10_inv(x);
                if (g > max) max = g;
                sum += g;

                //    Console.WriteLine("x = " + x);
                //    Console.WriteLine("g(x) = " + g);

            }

            average = sum / 10.0;
            if (Math.Abs(max - average) < 0.000001)
                Console.WriteLine("Results are almost equal");

            Console.WriteLine("Average = " + average);
            Console.WriteLine("Max = " + max);

            Console.WriteLine();




            /// Создание CSV-файлов

            double result; // Результат функции
            double t; // Шаг
            double absoluteError; // Абсолютная погрешность
            double relativeError; // Относительная погрешность

            /// g(x) = (x + A)^(2k + 1) + B
            /// g_inv(x) = (x - B)^(1/(2k + 1)) - A
            /// (w, w) -> (w, w)
            /// 
            System.IO.StreamWriter file1 =
            new System.IO.StreamWriter(@"D:\PRACTICE\K\CSV\interval_ww_ww_1_1.csv");
            file1.WriteLine("x" + ';' + "g_ginvx" + ';' + "absoluteError" + ';' + "relativeError");

            
            g = 0; g_inv = 0;
            result = 0;
            x = -50;
            t = 1.0 / 10.0;

            double A = R.NextDouble();
            double B = R.NextDouble();
            int k = R.Next(-5, 5);

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g_inv = Cinterval_ww_ww_1_inv.interval_ww_ww_1_inv(x, A, B, k);
                g = Cinterval_ww_ww_1.interval_ww_ww_1(g_inv, A, B, k);

                result = g;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                file1.WriteLine(x.ToString() + ';' + result.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());

            }
            file1.Close();

            System.IO.StreamWriter file1_1 =
            new System.IO.StreamWriter(@"D:\PRACTICE\K\CSV\interval_ww_ww_1_2.csv");
            file1_1.WriteLine("x" + ';' + "ginv_gx" + ';' + "absoluteError" + ';' + "relativeError");

            g = 0; g_inv = 0;
            result = 0;
            x = -50;
            t = 1.0 / 10.0;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g = Cinterval_ww_ww_1.interval_ww_ww_1(x, A, B, k);
                g_inv = Cinterval_ww_ww_1_inv.interval_ww_ww_1_inv(g, A, B, k);

                result = g_inv;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                file1_1.WriteLine(x.ToString() + ';' + result.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());

            }
            file1_1.Close();



            /// g(x) = x / sqrt(x*x + C)
            /// g_inv(x) = sqrt(C) * x / sqrt(1 - x*x)
            /// (w, w) -> (-1, 1)

            System.IO.StreamWriter file2 =
            new System.IO.StreamWriter(@"D:\PRACTICE\K\CSV\interval_ww_finfin_2_1.csv");
            file2.WriteLine("x" + ';' + "g_ginvx" + ';' + "absoluteError" + ';' + "relativeError");

            g = 0; g_inv = 0;
            result = 0;
            x = -0.5;
            t = 1.0 / 1000.0;

            C = R.NextDouble();

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g_inv = Cinterval_ww_finfin_2_inv.interval_ww_finfin_2_inv(x, C);
                g = Cinterval_ww_finfin_2.interval_ww_finfin_2(g_inv, C);

                result = g;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                file2.WriteLine(x.ToString() + ';' + result.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());

            }
            file2.Close();

            System.IO.StreamWriter file2_1 =
            new System.IO.StreamWriter(@"D:\PRACTICE\K\CSV\interval_ww_finfin_2_2.csv");
            file2_1.WriteLine("x" + ';' + "ginv_gx" + ';' + "absoluteError" + ';' + "relativeError");

            g = 0; g_inv = 0;
            result = 0;
            x = -50;
            t = 1.0 / 10.0;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g = Cinterval_ww_finfin_2.interval_ww_finfin_2(x, C);
                g_inv = Cinterval_ww_finfin_2_inv.interval_ww_finfin_2_inv(g, C);

                result = g_inv;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                file2_1.WriteLine(x.ToString() + ';' + result.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());

            }
            file2_1.Close();



            /// g(x) = tg(x)
            /// g_inv(x) = arctg(x)
            /// (-Pi/2, Pi/2) -> (w, w)

            System.IO.StreamWriter file3 =
            new System.IO.StreamWriter(@"D:\PRACTICE\K\CSV\interval_finfin_ww_3_1.csv");
            file3.WriteLine("x" + ';' + "g_ginvx" + ';' + "absoluteError" + ';' + "relativeError");

            g = 0; g_inv = 0;
            result = 0;
            x = -50;
            t = 1.0 / 10.0;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g_inv = Cinterval_finfin_ww_3_inv.interval_finfin_ww_3_inv(x);
                g = Cinterval_finfin_ww_3.interval_finfin_ww_3(g_inv);

                result = g;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                file3.WriteLine(x.ToString() + ';' + result.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());

            }
            file3.Close();

            System.IO.StreamWriter file3_1 =
            new System.IO.StreamWriter(@"D:\PRACTICE\K\CSV\interval_finfin_ww_3_2.csv");
            file3_1.WriteLine("x" + ';' + "ginv_gx" + ';' + "absoluteError" + ';' + "relativeError");

            g = 0; g_inv = 0;
            result = 0;
            x = -Math.PI / 2;
            t = Math.PI / 1000.0;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g = Cinterval_finfin_ww_3.interval_finfin_ww_3(x);
                g_inv = Cinterval_finfin_ww_3_inv.interval_finfin_ww_3_inv(g);

                result = g_inv;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                file3_1.WriteLine(x.ToString() + ';' + result.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());

            }
            file3_1.Close();


            /// g(x) = 1/x
            /// g_inv(x) = 1/x
            /// (0, w) -> (0, w)

            System.IO.StreamWriter file4 =
            new System.IO.StreamWriter(@"D:\PRACTICE\K\CSV\interval_finw_finw_4_1.csv");
            file4.WriteLine("x" + ';' + "g_ginvx" + ';' + "absoluteError" + ';' + "relativeError");

            g = 0; g_inv = 0;
            result = 0;
            x = 0;
            t = 1.0 / 10.0;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g_inv = Cinterval_finw_finw_4_inv.interval_finw_finw_4_inv(x);
                g = Cinterval_finw_finw_4.interval_finw_finw_4(g_inv);

                result = g;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                file4.WriteLine(x.ToString() + ';' + result.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());

            }
            file4.Close();

            System.IO.StreamWriter file4_1 =
            new System.IO.StreamWriter(@"D:\PRACTICE\K\CSV\interval_finw_finw_4_2.csv");
            file4_1.WriteLine("x" + ';' + "ginv_gx" + ';' + "absoluteError" + ';' + "relativeError");

            g = 0; g_inv = 0;
            result = 0;
            x = 0;
            t = 1.0 / 10.0;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g = Cinterval_finw_finw_4.interval_finw_finw_4(x);
                g_inv = Cinterval_finw_finw_4_inv.interval_finw_finw_4_inv(g);

                result = g_inv;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                file4_1.WriteLine(x.ToString() + ';' + result.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());

            }
            file4_1.Close();


            /// g(x) = -x
            /// g_inv(x) = -x
            /// (0, w) -> (w, 0)

            System.IO.StreamWriter file5 =
            new System.IO.StreamWriter(@"D:\PRACTICE\K\CSV\interval_finw_wfin_5_1.csv");
            file5.WriteLine("x" + ';' + "g_ginvx" + ';' + "absoluteError" + ';' + "relativeError");

            g = 0; g_inv = 0;
            result = 0;
            x = -100;
            t = 1.0 / 10.0;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g_inv = Cinterval_finw_wfin_5_inv.interval_finw_wfin_5_inv(x);
                g = Cinterval_finw_wfin_5.interval_finw_wfin_5(g_inv);

                result = g;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                file5.WriteLine(x.ToString() + ';' + result.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());

            }
            file5.Close();

            System.IO.StreamWriter file5_1 =
            new System.IO.StreamWriter(@"D:\PRACTICE\K\CSV\interval_finw_wfin_5_2.csv");
            file5_1.WriteLine("x" + ';' + "ginv_gx" + ';' + "absoluteError" + ';' + "relativeError");

            g = 0; g_inv = 0;
            result = 0;
            x = 0;
            t = 1.0 / 10.0;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g = Cinterval_finw_wfin_5.interval_finw_wfin_5(x);
                g_inv = Cinterval_finw_wfin_5_inv.interval_finw_wfin_5_inv(g);

                result = g_inv;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                file5_1.WriteLine(x.ToString() + ';' + result.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());

            }
            file5_1.Close();


            /// g(x) = A*exp(x + B)
            /// g_inv(x) = ln(x / A) - B
            /// (w, w) -> (0, w)
            /// 
            System.IO.StreamWriter file6 =
            new System.IO.StreamWriter(@"D:\PRACTICE\K\CSV\interval_ww_finw_6_1.csv");
            file6.WriteLine("x" + ';' + "g_ginvx" + ';' + "absoluteError" + ';' + "relativeError");


            g = 0; g_inv = 0;
            result = 0;
            x = 0;
            t = 1.0 / 10.0;

            A = R.NextDouble();
            B = R.NextDouble();

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g_inv = Cinterval_ww_finw_6_inv.interval_ww_finw_6_inv(x, A, B);
                g = Cinterval_ww_finw_6.interval_ww_finw_6(g_inv, A, B);

                result = g;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                file6.WriteLine(x.ToString() + ';' + result.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());

            }
            file6.Close();

            System.IO.StreamWriter file6_1 =
            new System.IO.StreamWriter(@"D:\PRACTICE\K\CSV\interval_ww_finw_6_2.csv");
            file6_1.WriteLine("x" + ';' + "ginv_gx" + ';' + "absoluteError" + ';' + "relativeError");

            g = 0; g_inv = 0;
            result = 0;
            x = -50;
            t = 1.0 / 10.0;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g = Cinterval_ww_finw_6.interval_ww_finw_6(x, A, B);
                g_inv = Cinterval_ww_finw_6_inv.interval_ww_finw_6_inv(g, A, B);

                result = g_inv;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                file6_1.WriteLine(x.ToString() + ';' + result.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());

            }
            file6_1.Close();


            /// g(x) = ((c - d)/(a - b)) * x + (ad - bc) / (a - b)
            /// g_inv(x) = ((a - b)/(c -d)) * x + (bc - ad) / (c - d)
            /// (a, b) -> (c, d)
            
            System.IO.StreamWriter file7 =
            new System.IO.StreamWriter(@"D:\PRACTICE\K\CSV\interval_finfin_finfin_7_1.csv");
            file7.WriteLine("x" + ';' + "g_ginvx" + ';' + "absoluteError" + ';' + "relativeError");


            g = 0; g_inv = 0;
            result = 0;

            t = 1.0 / 10.0;

            a = R.Next(-50, 50);
            b = a + 100;

            c = R.Next(-50, 50);
            d = c + 100;
            x = c;


            for (i = 1; i < 1000; i++)
            {
                x += t;

                g_inv = Cinterval_finfin_finfin_7_inv.interval_finfin_finfin_7_inv(x, a, b, c, d);
                g = Cinterval_finfin_finfin_7.interval_finfin_finfin_7(g_inv, a, b, c, d);

                result = g;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                file7.WriteLine(x.ToString() + ';' + result.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());

            }
            file7.Close();

            System.IO.StreamWriter file7_1 =
            new System.IO.StreamWriter(@"D:\PRACTICE\K\CSV\interval_finfin_finfin_7_2.csv");
            file7_1.WriteLine("x" + ';' + "ginv_gx" + ';' + "absoluteError" + ';' + "relativeError");

            g = 0; g_inv = 0;
            result = 0;

            t = 1.0 / 10.0;

            a = R.Next(-50, 50); 
            b = a + 100;
            x = a;

            c = R.Next(-50, 50);
            d = c + 100;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g = Cinterval_finfin_finfin_7.interval_finfin_finfin_7(x, a, b, c, d);
                g_inv = Cinterval_finfin_finfin_7_inv.interval_finfin_finfin_7_inv(g, a, b, c, d);

                result = g_inv;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                file7_1.WriteLine(x.ToString() + ';' + result.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());

            }
            file7_1.Close();


            /// g(x) = (ab*(d - c)/(a - b)) / x + (ac - bd) / (a - b)
            /// g_inv(x) = (d - c)*a*b/(x*(a- b) - (a*c - b*d))
            /// (a, b) -> (c, d)

            System.IO.StreamWriter file8 =
            new System.IO.StreamWriter(@"D:\PRACTICE\K\CSV\interval_finfin_finfin_8_1.csv");
            file8.WriteLine("x" + ';' + "g_ginvx" + ';' + "absoluteError" + ';' + "relativeError");


            g = 0; g_inv = 0;
            result = 0;

            a = R.Next(1, 10) + R.NextDouble();
            b = a + R.Next(2, 10) + R.NextDouble();

            c = R.Next(1, 10) + R.NextDouble();
            d = c + R.Next(2, 10) + R.NextDouble();

            t = (d - c) / 1000.0;
            x = c;


            for (i = 1; i < 1000; i++)
            {
                x += t;

                g_inv = Cinterval_finfin_finfin_8_inv.interval_finfin_finfin_8_inv(x, a, b, c, d);
                g = Cinterval_finfin_finfin_8.interval_finfin_finfin_8(g_inv, a, b, c, d);

                result = g;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                file8.WriteLine(x.ToString() + ';' + result.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());

            }
            file8.Close();

            System.IO.StreamWriter file8_1 =
            new System.IO.StreamWriter(@"D:\PRACTICE\K\CSV\interval_finfin_finfin_8_2.csv");
            file8_1.WriteLine("x" + ';' + "ginv_gx" + ';' + "absoluteError" + ';' + "relativeError");

            g = 0; g_inv = 0;
            result = 0;

            t = 1.0 / 10.0;

            a = R.Next(1, 10) + R.NextDouble();
            b = a + R.Next(2, 10) + R.NextDouble();
            t = (b - a) / 1000.0;
            x = a;

            c = R.Next(1, 10) + R.NextDouble();
            d = c + R.Next(2, 10) + R.NextDouble();

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g = Cinterval_finfin_finfin_8.interval_finfin_finfin_8(x, a, b, c, d);
                g_inv = Cinterval_finfin_finfin_8_inv.interval_finfin_finfin_8_inv(g, a, b, c, d);

                result = g_inv;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                file8_1.WriteLine(x.ToString() + ';' + result.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());

            }
            file8_1.Close();


            /// g(x) = sin(x)
            /// g_inv(x) = arcsin(x)
            /// (-Pi/2, Pi/2) -> (-1, 1)

            System.IO.StreamWriter file9 =
            new System.IO.StreamWriter(@"D:\PRACTICE\K\CSV\interval_finfin_finfin_9_1.csv");
            file9.WriteLine("x" + ';' + "g_ginvx" + ';' + "absoluteError" + ';' + "relativeError");

            g = 0; g_inv = 0;
            result = 0;
            x = -0.5;
            t = 1.0 / 1000.0;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g_inv = Cinterval_finfin_finfin_9_inv.interval_finfin_finfin_9_inv(x);
                g = Cinterval_finfin_finfin_9.interval_finfin_finfin_9(g_inv);

                result = g;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                file9.WriteLine(x.ToString() + ';' + result.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());

            }
            file9.Close();

            System.IO.StreamWriter file9_1 =
            new System.IO.StreamWriter(@"D:\PRACTICE\K\CSV\interval_finfin_finfin_9_2.csv");
            file9_1.WriteLine("x" + ';' + "ginv_gx" + ';' + "absoluteError" + ';' + "relativeError");

            g = 0; g_inv = 0;
            result = 0;
            x = -Math.PI / 2;
            t = Math.PI / 1000.0;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g = Cinterval_finfin_finfin_9.interval_finfin_finfin_9(x);
                g_inv = Cinterval_finfin_finfin_9_inv.interval_finfin_finfin_9_inv(g);

                result = g_inv;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                file9_1.WriteLine(x.ToString() + ';' + result.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());

            }
            file9_1.Close();


            /// g(x) = cos(x)
            /// g_inv(x) = arccos(x)
            /// (0, Pi) -> (-1, 1)

            System.IO.StreamWriter file10 =
            new System.IO.StreamWriter(@"D:\PRACTICE\K\CSV\interval_finfin_finfin_10_1.csv");
            file10.WriteLine("x" + ';' + "g_ginvx" + ';' + "absoluteError" + ';' + "relativeError");

            g = 0; g_inv = 0;
            result = 0;
            x = -0.5;
            t = 1.0 / 1000.0;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g_inv = Cinterval_finfin_finfin_10_inv.interval_finfin_finfin_10_inv(x);
                g = Cinterval_finfin_finfin_10.interval_finfin_finfin_10(g_inv);

                result = g;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                file10.WriteLine(x.ToString() + ';' + result.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());

            }
            file10.Close();

            System.IO.StreamWriter file10_1 =
            new System.IO.StreamWriter(@"D:\PRACTICE\K\CSV\interval_finfin_finfin_10_2.csv");
            file10_1.WriteLine("x" + ';' + "ginv_gx" + ';' + "absoluteError" + ';' + "relativeError");

            g = 0; g_inv = 0;
            result = 0;
            x = 0;
            t = Math.PI / 1000.0;

            for (i = 1; i < 1000; i++)
            {
                x += t;

                g = Cinterval_finfin_finfin_10.interval_finfin_finfin_10(x);
                g_inv = Cinterval_finfin_finfin_10_inv.interval_finfin_finfin_10_inv(g);

                result = g_inv;

                absoluteError = Math.Abs(result - x);
                relativeError = Math.Abs((result - x) / result);

                file10_1.WriteLine(x.ToString() + ';' + result.ToString() + ';' + absoluteError.ToString() + ';' + relativeError.ToString());

            }
            file10_1.Close();


            Console.WriteLine("CSV-files generated successfully");
        }
    }
}

