#define DEBUG
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunctionsLibrary;

namespace FirstProject
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
            double x, g;
            double C, a, b, c, d;

            //-------------------------------------------------------------

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

//------------------------------------------------------
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



//----------------------------------------------------------------------------------
//----------------------------------------------------------------------------------
//----------------------------------------------------------------------------------
            max = sum = average = 0;
            i = 1; 
            Console.WriteLine("g(x) = ((c - d)/(a - b)) * x + (a*d - b*c) / (a - b), x in (a, b)");

            a = R.NextDouble();
            b = a + R.Next(2, 10) + R.NextDouble();
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            x = a + R.NextDouble();

            c = R.NextDouble();
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

//----------------------------------------------------
            max = sum = average = 0;
            i = 1;
            Console.WriteLine("g_inv(x) = ((a - b)/(c -d)) * x + (bc - ad) / (c - d), x in (c, d)");

            a = R.NextDouble();
            b = a + R.Next(2, 10) + R.NextDouble();

            c = R.NextDouble();
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




//----------------------------------------------------
            max = sum = average = 0;
            i = 1;
            Console.WriteLine("g(x) = (ab*(d - c)/(a - b)) / x + (ac - bd) / (a - b), x in (a, b)");

            a = R.NextDouble();
            b = a + R.Next(2, 10) + R.NextDouble();
            x = a + R.NextDouble();
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);

            c = R.NextDouble();
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


//----------------------------------------------------
            max = sum = average = 0;
            i = 1;
            Console.WriteLine("g_inv(x) = (d - c)*a*b/(x*(a- b) - (a*c - b*d)), x in (c, d)");

            a = R.NextDouble();
            b = a + R.Next(2, 10) + R.NextDouble();

            c = R.NextDouble();
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

            
//----------------------------------------------------------------------------
//----------------------------------------------------------------------------
//----------------------------------------------------------------------------

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


//------------------------------------------------------
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




//------------------------------------------------------
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


            //------------------------------------------------------
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

        }
    }
}
