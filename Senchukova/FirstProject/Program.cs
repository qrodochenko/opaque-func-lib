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
            //---------------1----------------
            Console.WriteLine("Function_1");
            double k = Cinterval_ww_finfin_1.interval_ww_finfin_1(3);
            Console.WriteLine(k);
            Console.WriteLine(Cinterval_ww_finfin_1_in.interval_ww_finfin_1_in());
            Console.WriteLine();
            
            //---------------2----------------
            Console.WriteLine("Function_2");
            double m = Cinterval_ww_finfin_2.interval_ww_finfin_2(1);
            Console.WriteLine(m);
            Console.WriteLine();

            
            //----------------3---------------
            Console.WriteLine("Function_3");
            double l = Cinterval_ww_finfin_3.interval_ww_finfin_3(1, 1, 2); //f(x) = x / (x^2 + x + 2), x = 1
            Console.WriteLine(l);
            Console.WriteLine();
/*
            Random R = new Random();
            for (int i = 1; i <= 10; i++)
            {
                double x = Convert.ToDouble(R.Next(-1000, 1000) / 100.0);
                double A = Convert.ToDouble(R.Next(-1000, 1000) / 100.0);
                double B = Convert.ToDouble(R.Next(-1000, 1000) / 100.0);

                Console.WriteLine("A = " + A.ToString());
                Console.WriteLine("B = " + B.ToString());
                Console.WriteLine("x = " + x.ToString());

                double v = Cinterval_ww_finfin_3.interval_ww_finfin_3(x, A, B);

                Console.WriteLine("g(x) = " + v);

                Console.WriteLine();
            } */

            //----------------4----------------
            Console.WriteLine("Function_4");
            double n = Cinterval_ww_finfin_4.interval_ww_finfin_4(0); 
            Console.WriteLine(n);
            Console.WriteLine();

            Random Rnd = new Random();
            for (int i = 1; i <= 10; i++)
            {
                double x = (Rnd.NextDouble() - .5) * Math.PI;

                Console.WriteLine("x = " + x.ToString());

                double w = Cinterval_ww_finfin_4.interval_ww_finfin_4(x);

                Console.WriteLine("g(x) = " + w);

                Console.WriteLine();
            }

            //----------------5----------------

            Console.WriteLine("Function_5");
            double z = Cinterval_ww_finfin_4.interval_ww_finfin_4(0);
            Console.WriteLine(z);
            Console.WriteLine();

            Random Rand = new Random();
            for (int i = 1; i <= 10; i++)
            {
                double x = (Rand.NextDouble() - .5) * Math.PI;

                Console.WriteLine("x = " + x.ToString());

                double y = Cinterval_ww_finfin_4.interval_ww_finfin_4(x);

                Console.WriteLine("g(x) = " + y);

                Console.WriteLine();
            }

            Console.ReadKey();
            
        }
    }
}
